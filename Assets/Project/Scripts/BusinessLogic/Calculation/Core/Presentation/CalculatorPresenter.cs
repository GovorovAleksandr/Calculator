using System.Linq;
using Calculation.Configs;
using Calculation.Core.Calculator.Model;
using Calculation.Core.Calculator.Presentation;
using Calculation.Core.Calculator.Validation;
using Calculation.Core.Calculator.View;
using Calculation.Core.InputParser;
using Calculation.Data;
using EventBus.Public;
using Events.BusinessLogic;
using Events.Infrastructure;
using Zenject;

namespace Calculation.Core.Presentation
{
    internal sealed class CalculatorPresenter :
        ICalculatorPresenter,
        IEventHandler<ResourceLoaded<CalculatorPresenterConfig>>,
        IAutoRegistrableEventHandler
    {
        [Inject] private readonly IEventBusSender _eventBus;
        
        [Inject] private readonly ICalculator _calculator;
        [Inject] private readonly IResultView _resultView;
        [Inject] private readonly ICalculatorInputValidator _validator;
        [Inject] private readonly IInputParser _inputParser;

        private CalculatorPresenterConfig _config;

        private string _lastEquation;

        public void Handle(ResourceLoaded<CalculatorPresenterConfig> eventData)
        {
            _config ??= eventData.Resource;
        }

        public void ResultButtonClicked(string rawEquation)
        {
            var normalizedEquation = string.Join(Constants.PlusChar.ToString(), rawEquation
                .Replace(Constants.SpaceChar.ToString(), string.Empty)
                .Replace(Constants.StringTransfer, string.Empty)
                .Split(Constants.PlusChar)
                .Select(part => part.TrimStart(Constants.ZeroChar)));
    
            if (_lastEquation == normalizedEquation) return;
            _lastEquation = normalizedEquation;

            var isValid = _validator.Validate(normalizedEquation);
            var result = isValid ? _calculator.Sum(_inputParser.Parse(normalizedEquation)) : 0;
            var fullEquationText = string.Format(_config.ResultFormat, normalizedEquation, isValid ? result : _config.InvalidInputResult);
    
            _resultView.ShowResult(fullEquationText);
            _eventBus.Send(new ResultCalculated(result));

            if (!isValid) _eventBus.Send(new ShowDialogWindow(_config.InvalidInputMessage));
        }
    }
}