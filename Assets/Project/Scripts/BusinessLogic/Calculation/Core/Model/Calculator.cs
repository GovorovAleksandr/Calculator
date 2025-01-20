using System.Linq;
using System.Numerics;

namespace Calculation.Core.Calculator.Model
{
    internal sealed class Calculator : ICalculator
    {
        public BigInteger Sum(params BigInteger[] numbers)
        {
            return numbers.Aggregate(BigInteger.Zero,
                (current, number) => current + number);
        }
    }
}