using Calculation.Data;
using TMPro;
using UnityEngine;

namespace Calculation.Core.View
{
    [CreateAssetMenu(menuName = "Project/Calculation/CalculatorInputViewValidator", fileName = "CalculatorInputViewValidator")]
    internal sealed class CalculatorInputViewValidator : TMP_InputValidator
    {
        public override char Validate(ref string text, ref int pos, char ch)
        {
            if (ch == Constants.SpaceChar)
            {
                if (pos == 0 || (pos > 0 && text[pos - 1] == Constants.SpaceChar))
                {
                    return '\0';
                }
            }
            
            text = text.Insert(pos, ch.ToString());
            pos++;
            return ch;
        }
    }
}