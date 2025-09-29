using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using K3DAsyncEngineLib;

namespace VLeague.Services.Visual
{
    public class K3DVisualCGService : IVisualCGService
    {
        private readonly KAEngine _engine;
        private IVisualScenePlayer _scenePlayer;

        public K3DVisualCGService()
        {
            _engine = new KAEngine();
        }

        public event EventHandler<ConnectionEventArgs> ConnectionChanged;

        public IVisualScenePlayer ScenePlayer
        {
            get
            {
                if (_scenePlayer == null)
                {
                    var rawPlayer = _engine.GetScenePlayer();
                    _scenePlayer = rawPlayer != null ? new K3DVisualScenePlayer(rawPlayer) : null;
                }

                return _scenePlayer;
            }
        }

        public async Task<bool> ConnectAsync(string endpoint, Dictionary<string, object> connectionParams)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var port = ExtractPort(connectionParams);
                    var handler = ExtractEventHandler(connectionParams);
                    _engine.KTAPConnect(1, endpoint, port, 0, handler);
                    _scenePlayer = new K3DVisualScenePlayer(_engine.GetScenePlayer());
                    OnConnectionChanged(new ConnectionEventArgs(true, "Connected", connectionParams));
                    return true;
                }
                catch (Exception ex)
                {
                    OnConnectionChanged(new ConnectionEventArgs(false, ex.Message, connectionParams));
                    return false;
                }
            });
        }

        public void Disconnect()
        {
            _engine.Disconnect();
            _scenePlayer = null;
            OnConnectionChanged(new ConnectionEventArgs(false, "Disconnected"));
        }

        public IVisualScene LoadScene(string projectPath, string sceneName)
        {
            var scene = _engine.LoadScene(projectPath, sceneName);
            return scene != null ? new K3DVisualScene(scene) : null;
        }

        public void BeginTransaction()
        {
            _engine.BeginTransaction();
        }

        public void EndTransaction()
        {
            _engine.EndTransaction();
        }

        public void UnloadAll()
        {
            _engine.UnloadAll();
        }

        private static int ExtractPort(Dictionary<string, object> connectionParams)
        {
            if (connectionParams != null && connectionParams.ContainsKey("Port"))
            {
                var rawPort = connectionParams["Port"];
                if (rawPort is int directPort)
                {
                    return directPort;
                }

                if (rawPort is string portString && int.TryParse(portString, out var parsedPort))
                {
                    return parsedPort;
                }
            }

            return 0;
        }

        private static IKAEventHandler ExtractEventHandler(Dictionary<string, object> connectionParams)
        {
            if (connectionParams != null && connectionParams.ContainsKey("EventHandler"))
            {
                return connectionParams["EventHandler"] as IKAEventHandler;
            }

            return null;
        }

        private void OnConnectionChanged(ConnectionEventArgs args)
        {
            var handler = ConnectionChanged;
            handler?.Invoke(this, args);
        }

        private class K3DVisualScene : IVisualScene
        {
            private readonly KAScene _scene;

            public K3DVisualScene(KAScene scene)
            {
                _scene = scene;
            }

            public IVisualObject GetObject(string name)
            {
                var obj = _scene?.GetObject(name);
                return obj != null ? new K3DVisualObject(obj) : null;
            }

            public void DeletePause(int animationType, int frameNo, int applyToAll)
            {
                _scene?.DeletePause(animationType, frameNo, applyToAll != 0);
            }

            public KAScene InnerScene => _scene;
        }

        private class K3DVisualScenePlayer : IVisualScenePlayer
        {
            private readonly KAScenePlayer _player;

            public K3DVisualScenePlayer(KAScenePlayer player)
            {
                _player = player;
            }

            public void Play(int layer)
            {
                _player?.Play(layer);
            }

            public void Pause(int layer)
            {
                _player?.Pause(layer);
            }

            public void Stop(int layer)
            {
                _player?.Stop(layer);
            }

            public void PlayOut(int layer)
            {
                _player?.PlayOut(layer);
            }

            public void StopAll()
            {
                _player?.StopAll();
            }

            public void Resume(int layer)
            {
                _player?.Resume(layer);
            }

            public void Prepare(int layer, IVisualScene scene)
            {
                var k3dScene = scene as K3DVisualScene;
                if (k3dScene != null)
                {
                    _player?.Prepare(layer, k3dScene.InnerScene);
                }
            }

            public IVisualScene GetPlayingScene(int layer)
            {
                var rawScene = _player?.GetPlayingScene(layer);
                return rawScene != null ? new K3DVisualScene(rawScene) : null;
            }

            public KAScenePlayer InnerPlayer => _player;
        }

        private class K3DVisualObject : IVisualObject
        {
            private readonly KAObject _object;

            public K3DVisualObject(KAObject obj)
            {
                _object = obj;
            }

            public void SetValue(object value)
            {
                _object?.SetValue(value);
            }

            public void SetCounterRange(double startTime, double endTime)
            {
                _object?.SetCounterRange(startTime, endTime);
            }

            public void SetFaceColor(int red, int green, int blue, int alpha)
            {
                _object?.SetFaceColor(red, green, blue, alpha);
            }

            public void SetVisible(int visible)
            {
                _object?.SetVisible(visible);
            }

            public void SetOpacity(int opacity)
            {
                _object?.SetOpacity(opacity);
            }
        }

        internal KAScenePlayer GetRawScenePlayer()
        {
            if (_scenePlayer is K3DVisualScenePlayer player)
            {
                return player.InnerPlayer;
            }

            return _engine.GetScenePlayer();
        }

        internal KAScene ToRawScene(IVisualScene scene)
        {
            var k3dScene = scene as K3DVisualScene;
            return k3dScene?.InnerScene;
        }
    }
}
