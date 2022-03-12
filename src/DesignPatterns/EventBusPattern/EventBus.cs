using DesignPatterns.EventBusPattern.EventHandlers;
using DesignPatterns.EventBusPattern.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public class EventBus : IEventBus
    {
        private readonly ISubscriptionsManager _subscriptionsManager;
        private readonly IServiceProvider _serviceProvider;
        public EventBus(ISubscriptionsManager subscriptionsManager, IServiceProvider serviceProvider)
        {
            _subscriptionsManager = subscriptionsManager;
            _serviceProvider = serviceProvider;
        }

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var subscriptions = _subscriptionsManager.GetSubscriptions(typeof(TEvent).Name);
            foreach (var subscription in subscriptions)
            {
                var handler = (IEventHandler<TEvent>)_serviceProvider.GetService(subscription.HandlerType);
                handler.Handle(@event);
            }
        }

        public void Subcribe<TEvent, TEventHandler>()
            where TEvent : IEvent
            where TEventHandler : IEventHandler<TEvent>
        {
            _subscriptionsManager.AddSubscriber<TEvent, TEventHandler>();
        }
    }
}
