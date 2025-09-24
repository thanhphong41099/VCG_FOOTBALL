

using VLeague.src.menu;

namespace VLeague
{
    internal class EventHandlerNews : EventHandler
    {
        public FrmSettingNews Owner;
        public EventHandlerNews(FrmSettingNews _Owner)
        {
            Owner = _Owner;
        }

        public override void OnLogMessage(string LogMessage)
        {
            Owner.OnLogMessage(LogMessage);
        }
    }
}
