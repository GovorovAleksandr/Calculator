using System;
using DataPersistence.Public;

namespace Calculation.Data
{
    [Serializable]
    internal struct SaveData : ISavableData
    {
        public string EquationText;
        public string ResultText;

        public SaveData(string equationText, string resultText)
        {
            EquationText = equationText;
            ResultText = resultText;
        }
    }
}