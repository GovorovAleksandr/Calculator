using Calculation.Data;
using EventBus.Public;
using Events.Infrastructure;
using TMPro;

namespace Calculation.Core.Calculator.View
{
    internal sealed class ResultView :
        IResultView,
        IEventHandler<MonoReferenceLoaded<CalculatorResultViewReferenceData>>,
        IAutoRegistrableEventHandler
    {
        private TextMeshProUGUI _resultText;
        
        public void Handle(MonoReferenceLoaded<CalculatorResultViewReferenceData> eventData)
        {
            _resultText ??= eventData.Data.ResultText;
        }

        public void ShowResult(string result)
        {
            if (!string.IsNullOrEmpty(_resultText.text)) _resultText.text += Constants.StringTransfer;
            _resultText.text += result;
        }
    }
}