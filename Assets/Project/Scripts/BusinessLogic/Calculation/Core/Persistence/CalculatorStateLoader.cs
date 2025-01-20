using Calculation.Data;
using DataPersistence.Events;
using EventBus.Public;
using Events.Infrastructure;
using Zenject;

namespace Calculation.Core.Calculator.Persistence
{
    internal sealed class CalculatorStateLoader :
        IEventHandler<MonoReferenceLoaded<CalculatorResultViewReferenceData>>,
        IEventHandler<DataLoaded<SaveData>>,
        IAutoRegistrableEventHandler
    {
        private string _textValue;

        public void Handle(DataLoaded<SaveData> eventData)
        {
            _textValue = eventData.Data.ResultText;
        }

        public void Handle(MonoReferenceLoaded<CalculatorResultViewReferenceData> eventData)
        {
            eventData.Data.ResultText.SetText(_textValue);
        }
    }
}