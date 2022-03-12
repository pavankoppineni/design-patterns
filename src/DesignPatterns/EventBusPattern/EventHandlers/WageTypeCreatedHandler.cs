using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.EventHandlers
{
    public class WageTypeCreatedHandler : IEventHandler<WageTypeCreated>
    {
        public void Handle(WageTypeCreated @event)
        {
            Console.WriteLine(@event.Code);
        }
    }
}
