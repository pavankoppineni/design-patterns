using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
