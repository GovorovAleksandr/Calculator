using System;
using System.Reflection;
using EventBus.Public;
using Events.Infrastructure;
using Zenject;

namespace EventBus.Core
{
    internal sealed class GenericEventSender :
        IEventHandler<SendGenericEvent>,
        IAutoRegistrableEventHandler
    {
        [Inject] private readonly IEventBus _eventBus;
        
        private Type RequestBusType => _eventBus.GetType();
        private string SendMethodName => nameof(_eventBus.Send);
        private MethodInfo SendMethod => RequestBusType.GetMethod(SendMethodName);
        
        public void Handle(SendGenericEvent data)
        {
            var rawEventType = data.RawEventType;
            var genericArgType = data.GenericArgType;
            var args = data.Args;
            
            var eventType = rawEventType.MakeGenericType(genericArgType);
            
            var eventInstance = Activator.CreateInstance(eventType, args);

            var method = SendMethod.MakeGenericMethod(eventType);
            method.Invoke(_eventBus, new[] { eventInstance });
        }
    }
}