using System.Collections.Generic;
using System.Threading.Tasks;

namespace VLeague.Services.Visual
{
    public interface IVisualEngine
    {
        Task<bool> ConnectAsync(string endpoint, Dictionary<string, object> connectionParams);

        void Disconnect();

        IVisualScenePlayer GetScenePlayer();

        IVisualScene LoadScene(string projectPath, string sceneName);

        void BeginTransaction();

        void EndTransaction();

        void UnloadAll();
    }
}
