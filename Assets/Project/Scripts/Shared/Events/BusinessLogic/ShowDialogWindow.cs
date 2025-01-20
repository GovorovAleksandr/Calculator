using Events.Public;

namespace Events.BusinessLogic
{
    public struct ShowDialogWindow : IEvent
    {
        public readonly string Message;

        public ShowDialogWindow(string message)
        {
            Message = message;
        }
    }
}