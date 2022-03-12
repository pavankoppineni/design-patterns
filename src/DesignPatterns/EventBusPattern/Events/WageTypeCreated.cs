using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.Events
{
    public class WageTypeCreated : Event
    {
        public string Code { get; set; }
        public decimal Value { get; set; }

        public static WageTypeCreated Create()
        {
            return new WageTypeCreated();
        }
    }
}
