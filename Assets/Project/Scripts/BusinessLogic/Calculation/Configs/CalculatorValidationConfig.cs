using UnityEngine;

namespace Calculation.Configs
{
    [CreateAssetMenu(menuName = "Project/Calculation/CalculatorValidationConfig", fileName = "CalculatorValidationConfig")]
    internal sealed class CalculatorValidationConfig : ScriptableObject
    {
        [SerializeField] [Min(2)] private int _maxAddends = 2;
        
        public int MaxAddends => _maxAddends;
    }
}