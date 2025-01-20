using System.Linq;
using System.Numerics;
using Calculation.Data;

namespace Calculation.Core.InputParser
{
    internal class InputParser : IInputParser
    {
        public BigInteger[] Parse(string rawInput)
        {
            var input = rawInput.Replace(Constants.SpaceChar.ToString(), string.Empty);
            var numbers = input.Split(Constants.PlusChar);

            return numbers
                .Select(number => BigInteger.TryParse(number, out var result) ? result : 0)
                .ToArray();
        }
    }
}