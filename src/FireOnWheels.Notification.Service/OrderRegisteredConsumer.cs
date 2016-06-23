using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireOnWheels.Messaging.Events;
using MassTransit;

namespace FireOnWheels.Notification.Service
{
    public class OrderRegisteredConsumer : IConsumer<IOrderRegisteredEvent>
    {
        public async Task Consume(ConsumeContext<IOrderRegisteredEvent> context) {
            var registeredEvent = context.Message;
            await Console.Out.WriteLineAsync($"Customer notification sent: Order Id {registeredEvent.OrderId} registered.");
        }
    }
}
