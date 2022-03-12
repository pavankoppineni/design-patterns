using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.Events
{
    public class Event : IEvent
    {
        public Guid Id => Guid.NewGuid();
        public DateTime DateTime => DateTime.UtcNow;
    }
}
