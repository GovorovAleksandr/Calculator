using UnityEngine;

namespace Calculation.Configs
{
    [CreateAssetMenu(menuName = "Project/Calculation/CalculatorPresenterConfig", fileName = "CalculatorPresenterConfig")]
    internal sealed class CalculatorPresenterConfig : ScriptableObject
    {
        [SerializeField] private string _resultFormat = "{0}={1}";
        [Multiline]
        [SerializeField] private string _invalidInputMessage = "";
        
        public string ResultFormat => _resultFormat;
        public string InvalidInputMessage => _invalidInputMessage;
    }
}