using DesignPatterns.EventBusPattern.EventHandlers;
using DesignPatterns.EventBusPattern.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventBusPattern
{
    public static class EventBusPatternPlayer
    {
        public static void Play()
        {
            var serviceProvider = ConfigureServices();
            var eventBus = serviceProvider.GetRequiredService<IEventBus>();
            eventBus.Subcribe<WageTypeCreated, WageTypeCreatedHandler>();
            eventBus.Subcribe<CurrencyCreated, CurrencyCreatedHandler>();

            var wageTypeCreatedMessage = WageTypeCreated.Create();
            eventBus.Publish(wageTypeCreatedMessage);
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ISubscriptionsManager, SubscriptionsManager>();
            serviceCollection.AddScoped<WageTypeCreatedHandler>();
            serviceCollection.AddScoped<CurrencyCreatedHandler>();
            serviceCollection.AddScoped<IEventBus, EventBus>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
