using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VLeague.Services.Visual
{
    public interface IVisualCGService
    {
        event EventHandler<ConnectionEventArgs> ConnectionChanged;

        Task<bool> ConnectAsync(string endpoint, Dictionary<string, object> connectionParams);

        void Disconnect();

        IVisualScenePlayer ScenePlayer { get; }

        IVisualScene LoadScene(string projectPath, string sceneName);

        void BeginTransaction();

        void EndTransaction();

        void UnloadAll();
    }
}
