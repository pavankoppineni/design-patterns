using DesignPatterns.EventBusPattern.EventHandlers;
using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event)
            where TEvent : IEvent;
        void Subcribe<TEvent, TEventHandler>()
            where TEvent : IEvent
            where TEventHandler : IEventHandler<TEvent>;
    }
}
