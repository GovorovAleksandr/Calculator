using Calculation.Core.Calculator.Presentation;
using Calculation.Data;
using EventBus.Public;
using Events.Infrastructure;
using TMPro;
using UnityEngine.UI;
using Zenject;

namespace Calculation.Core.View
{
    internal sealed class CalculatorInput :
        IEventHandler<MonoReferenceLoaded<CalculatorInputViewReferenceData>>,
        IAutoRegistrableEventHandler
    {
        [Inject] private readonly ICalculatorPresenter _presenter;
        
        private TMP_InputField _inputField;
        private Button _button;

        public void Handle(MonoReferenceLoaded<CalculatorInputViewReferenceData> eventData)
        {
            if (_inputField != null) return;
            if (_button != null) return;
            
            var data = eventData.Data;

            _inputField = data.InputField;
            _button = data.ResultButton;
            
            _button.onClick.AddListener(() => _presenter.ResultButtonClicked(_inputField.text));
        }
    }
}