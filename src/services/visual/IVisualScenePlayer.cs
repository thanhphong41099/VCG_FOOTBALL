namespace VLeague.Services.Visual
{
    public interface IVisualScenePlayer
    {
        void Play(int layer);

        void Pause(int layer);

        void Stop(int layer);

        void PlayOut(int layer);

        void StopAll();

        void Resume(int layer);

        void Prepare(int layer, IVisualScene scene);

        IVisualScene GetPlayingScene(int layer);
    }
}
