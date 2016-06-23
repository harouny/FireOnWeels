using System;
using System.Threading.Tasks;
using FireOnWheels.Messaging;
using FireOnWheels.Messaging.Commands;
using FireOnWheels.Messaging.Events;
using MassTransit;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace FireOnWheels.Registration.Service
{
    internal class RegisteredOrderCommandConsumer : DefaultBasicConsumer, MassTransit.IConsumer<IRegisterOrderCommand>
    {
        public RegisteredOrderCommandConsumer() { }

        static int orderId = 12;
        public async Task Consume(ConsumeContext<IRegisterOrderCommand> context) {
            var command = context.Message;
            await Console.Out.WriteLineAsync($"Successfully consumed order from {command.PickupName} to {command.DeliveryName}");

            var orderRegisteredEvent = new OrderRegisteredEvent(command, orderId++);
            await context.Publish<IOrderRegisteredEvent>(orderRegisteredEvent);
        }
    }
}