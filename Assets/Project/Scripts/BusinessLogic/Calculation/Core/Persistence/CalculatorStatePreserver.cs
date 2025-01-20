using Calculation.Data;
using DataPersistence.Events;
using EventBus.Public;
using Events.BusinessLogic;
using Events.Infrastructure;
using TMPro;
using Zenject;

namespace Calculation.Core.Calculator.Persistence
{
    internal sealed class CalculatorStatePreserver :
        IEventHandler<MonoReferenceLoaded<CalculatorResultViewReferenceData>>,
        IEventHandler<MonoReferenceLoaded<CalculatorInputViewReferenceData>>,
        IEventHandler<ResultCalculated>,
        IAutoRegistrableEventHandler
    {
        [Inject] private readonly IEventBusSender _eventBus;
        
        private TextMeshProUGUI _text;
        private TMP_InputField _inputField;
        
        public void Handle(MonoReferenceLoaded<CalculatorResultViewReferenceData> eventData)
        {
            _text ??= eventData.Data.ResultText;
        }

        public void Handle(MonoReferenceLoaded<CalculatorInputViewReferenceData> eventData)
        {
            _inputField ??= eventData.Data.InputField;
        }

        public void Handle(ResultCalculated eventData)
        {
            _eventBus.Send(new SaveGameplayData(new SaveData(_inputField.text, _text.text)));
        }
    }
}