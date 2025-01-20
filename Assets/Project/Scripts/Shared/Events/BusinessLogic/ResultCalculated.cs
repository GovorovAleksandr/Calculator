using System.Numerics;
using Events.Public;

namespace Events.BusinessLogic
{
    public struct ResultCalculated : IEvent
    {
        public readonly BigInteger Result;

        public ResultCalculated(BigInteger result)
        {
            Result = result;
        }
    }
}