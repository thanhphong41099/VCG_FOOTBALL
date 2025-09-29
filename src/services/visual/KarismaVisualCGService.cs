using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VLeague.Services.Visual
{
    public class KarismaVisualCGService : IVisualCGService
    {
        public event EventHandler<ConnectionEventArgs> ConnectionChanged;

        public IVisualScenePlayer ScenePlayer => throw new NotImplementedException();

        public Task<bool> ConnectAsync(string endpoint, Dictionary<string, object> connectionParams)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public IVisualScene LoadScene(string projectPath, string sceneName)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        public void UnloadAll()
        {
            throw new NotImplementedException();
        }
    }
}
