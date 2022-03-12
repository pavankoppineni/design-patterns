using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.EventHandlers
{
    public class CurrencyCreatedHandler : IEventHandler<CurrencyCreated>
    {
        public void Handle(CurrencyCreated @event)
        {
            Console.WriteLine(@event.Code);
        }
    }
}
