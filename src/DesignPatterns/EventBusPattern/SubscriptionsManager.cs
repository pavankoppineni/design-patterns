using DesignPatterns.EventBusPattern.EventHandlers;
using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public class SubscriptionsManager : ISubscriptionsManager
    {
        private readonly IDictionary<string, IList<SubscriptionInfo>> _subscriptions;
        public SubscriptionsManager()
        {
            _subscriptions = new Dictionary<string, IList<SubscriptionInfo>>();
        }

        public void AddSubscriber<TEvent, TEventHandler>()
            where TEvent : IEvent
            where TEventHandler : IEventHandler<TEvent>
        {
            var eventName = typeof(TEvent).Name;
            if (!_subscriptions.ContainsKey(eventName))
            {
                _subscriptions.Add(eventName, new List<SubscriptionInfo>());
            }
            _subscriptions[eventName].Add(SubscriptionInfo.Create(typeof(TEventHandler)));
        }

        public IList<SubscriptionInfo> GetSubscriptions(string eventName)
        {
            return _subscriptions[eventName];
        }
    }
}
