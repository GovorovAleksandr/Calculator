using DialogWindow.MonoReferences;
using EventBus.Public;
using Events.BusinessLogic;
using Events.Infrastructure;
using TMPro;
using UnityEngine;

namespace DialogWindow.Core
{
    internal sealed class DialogBoxDisplayer :
        IEventHandler<MonoReferenceLoaded<DialogWindowReferenceData>>,
        IEventHandler<ShowDialogWindow>,
        IAutoRegistrableEventHandler
    {
        private GameObject _window;
        private TextMeshProUGUI _messageText;
        
        public void Handle(MonoReferenceLoaded<DialogWindowReferenceData> eventData)
        {
            _window = eventData.Data.Window;
            _messageText = eventData.Data.MessageText;
            Hide();
        }

        public void Handle(ShowDialogWindow eventData)
        {
            _messageText.text = eventData.Message;
            Show();
        }
        
        private void Show() => _window.SetActive(true);
        private void Hide() => _window.SetActive(false);
    }
}