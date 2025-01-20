using Events.Public;

namespace DataPersistence.Public
{
    public interface ISaveEvent : IEvent
    {
        ISavableData Data { get; }
    }
}