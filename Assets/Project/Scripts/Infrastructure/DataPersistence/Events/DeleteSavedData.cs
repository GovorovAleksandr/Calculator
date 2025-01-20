using System;
using Events.Public;

namespace DataPersistence.Events
{
    public struct DeleteSavedData : IEvent
    {
        public readonly Type DataType;

        public DeleteSavedData(Type dataType)
        {
            DataType = dataType;
        }
    }
}