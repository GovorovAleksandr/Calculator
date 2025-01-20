using System.Numerics;

namespace Calculation.Core.InputParser
{
    internal interface IInputParser
    {
        BigInteger[] Parse(string rawInput);
    }
}