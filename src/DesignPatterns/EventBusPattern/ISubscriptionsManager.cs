using DesignPatterns.EventBusPattern.EventHandlers;
using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public interface ISubscriptionsManager
    {
        void AddSubscriber<TEvent, TEventHandler>()
            where TEvent : IEvent
            where TEventHandler : IEventHandler<TEvent>;

        IList<SubscriptionInfo> GetSubscriptions(string eventName);
    }
}
