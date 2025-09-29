namespace VLeague.Services.Visual
{
    public interface IVisualObject
    {
        void SetValue(object value);

        void SetCounterRange(double startTime, double endTime);

        void SetFaceColor(int red, int green, int blue, int alpha);

        void SetVisible(int visible);

        void SetOpacity(int opacity);
    }
}
