using Events.Public;

namespace Events.Infrastructure
{
    public struct MonoReferenceLoaded<T> : IEvent where T : struct
    {
        public readonly T Data;

        public MonoReferenceLoaded(T data)
        {
            Data = data;
        }
    }
}