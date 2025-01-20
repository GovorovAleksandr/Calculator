using Events.Public;
using UnityEngine;

namespace Events.Infrastructure
{
    public struct ResourceLoaded<T> : IEvent where T : ScriptableObject
    {
        public readonly T Resource;

        public ResourceLoaded(T resource)
        {
            Resource = resource;
        }
    }
}