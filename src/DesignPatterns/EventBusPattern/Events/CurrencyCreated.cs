using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern.Events
{
    public class CurrencyCreated : Event
    {
        public string Code { get; set; }
        public decimal Value { get; set; }

        public static CurrencyCreated Create()
        {
            return new CurrencyCreated();
        }
    }
}
