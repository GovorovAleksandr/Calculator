using System;
using MonoReferencing.Public;
using UnityEngine;

namespace Calculation.Configs
{
    [Serializable]
    internal struct CalculatorPopupReferenceData : IMonoReferenceData
    {
        public GameObject Popup;
    }
}