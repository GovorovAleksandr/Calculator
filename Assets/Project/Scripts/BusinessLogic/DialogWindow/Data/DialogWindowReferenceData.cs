using System;
using MonoReferencing.Public;
using TMPro;
using UnityEngine;

namespace DialogWindow.MonoReferences
{
    [Serializable]
    internal struct DialogWindowReferenceData : IMonoReferenceData
    {
        public GameObject Window;
        public TextMeshProUGUI MessageText;
    }
}