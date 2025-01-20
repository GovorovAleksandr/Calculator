using System.Numerics;

namespace Calculation.Core.Calculator.Model
{
    internal interface ICalculator
    {
        BigInteger Sum(params BigInteger[] numbers);
    }
}