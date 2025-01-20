using System;
using MonoReferencing.Public;
using TMPro;
using UnityEngine.UI;

namespace Calculation.Data
{
    [Serializable]
    internal struct CalculatorInputViewReferenceData : IMonoReferenceData
    {
        public TMP_InputField InputField;
        public Button ResultButton;
    }
}