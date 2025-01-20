using System;
using DataPersistence.Public;

namespace Calculation.Data
{
    [Serializable]
    internal struct SaveData : ISavableData
    {
        public string ResultText;

        public SaveData(string resultText)
        {
            ResultText = resultText;
        }
    }
}