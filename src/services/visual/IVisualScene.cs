namespace VLeague.Services.Visual
{
    public interface IVisualScene
    {
        IVisualObject GetObject(string name);

        void DeletePause(int animationType, int frameNo, int applyToAll);
    }
}
