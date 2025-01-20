using DataPersistence.Core;
using DataPersistence.Public;
using Events.Public;

namespace DataPersistence.Events
{
    internal struct SaveData : IEvent
    {
        public readonly ISavableData Data;
        public readonly BaseFileNameBuilder FileNameBuilder;

        public SaveData(ISavableData data, BaseFileNameBuilder fileNameBuilder)
        {
            Data = data;
            FileNameBuilder = fileNameBuilder;
        }
    }
}