using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public class SubscriptionInfo
    {
        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType;
        }

        public Type HandlerType { get; }

        public static SubscriptionInfo Create(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
