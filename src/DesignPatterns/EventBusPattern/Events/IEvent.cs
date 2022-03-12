using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.Events
{
    public interface IEvent
    {
        Guid Id { get; }
        DateTime DateTime { get; }
    }
}
