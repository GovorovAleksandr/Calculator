using System;
using MonoReferencing.Public;
using TMPro;

namespace Calculation.Data
{
    [Serializable]
    internal struct CalculatorResultViewReferenceData : IMonoReferenceData
    {
        public TextMeshProUGUI ResultText;
    }
}