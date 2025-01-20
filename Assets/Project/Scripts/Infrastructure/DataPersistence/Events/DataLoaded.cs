using DataPersistence.Public;
using Events.Public;

namespace DataPersistence.Events
{
    public struct DataLoaded<T> : IEvent where T : ISavableData
    {
        public readonly T Data;

        public DataLoaded(T data)
        {
            Data = data;
        }
    }
}