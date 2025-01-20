using System.Linq;
using Calculation.Configs;
using Calculation.Data;
using EventBus.Public;
using Events.Infrastructure;

namespace Calculation.Core.Calculator.Validation
{
    internal sealed class CalculatorInputValidator : ICalculatorInputValidator, IEventHandler<ResourceLoaded<CalculatorValidationConfig>>, IAutoRegistrableEventHandler
    {
        private CalculatorValidationConfig _validationConfig;
        
        public void Handle(ResourceLoaded<CalculatorValidationConfig> eventData)
        {
            _validationConfig ??= eventData.Resource;
        }

        public bool Validate(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            if (input.Any(character => !Constants.AvailableCharacters.Contains(character))) return false;
            if (!input.Contains(Constants.PlusChar)) return false;
            if (input.Last() == Constants.PlusChar) return false;
            return input.Split(Constants.PlusChar).Length <= _validationConfig.MaxAddends;
        }
    }
}