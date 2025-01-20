using Calculation.Data;
using DataPersistence.Events;
using EventBus.Public;
using Events.Infrastructure;
using Zenject;

namespace Calculation.Core.Calculator.Persistence
{
    internal sealed class CalculatorStateLoader :
        IEventHandler<MonoReferenceLoaded<CalculatorResultViewReferenceData>>,
        IEventHandler<MonoReferenceLoaded<CalculatorInputViewReferenceData>>,
        IEventHandler<DataLoaded<SaveData>>,
        IAutoRegistrableEventHandler
    {
        private string _equationText;
        private string _resultText;

        public void Handle(DataLoaded<SaveData> eventData)
        {
            _equationText = eventData.Data.EquationText;
            _resultText = eventData.Data.ResultText;
        }

        public void Handle(MonoReferenceLoaded<CalculatorInputViewReferenceData> eventData)
        {
            eventData.Data.InputField.text = _equationText;
        }

        public void Handle(MonoReferenceLoaded<CalculatorResultViewReferenceData> eventData)
        {
            eventData.Data.ResultText.SetText(_resultText);
        }
    }
}