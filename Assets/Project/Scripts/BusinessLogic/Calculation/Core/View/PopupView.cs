using Calculation.Configs;
using EventBus.Public;
using Events.BusinessLogic;
using Events.Infrastructure;
using UnityEngine;

namespace Calculation.Core.Calculator.View
{
    internal sealed class PopupView :
        IEventHandler<MonoReferenceLoaded<CalculatorPopupReferenceData>>,
        IEventHandler<ShowDialogWindow>,
        IAutoRegistrableEventHandler
    {
        private GameObject _popup;
        
        public void Handle(MonoReferenceLoaded<CalculatorPopupReferenceData> eventData)
        {
            _popup ??= eventData.Data.Popup;
        }

        public void Handle(ShowDialogWindow eventData)
        {
            _popup?.SetActive(false);
        }
    }
}