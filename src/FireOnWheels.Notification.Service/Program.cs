using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FireOnWheels.Messaging;
using FireOnWheels.Messaging.Events;
using MassTransit;

namespace FireOnWheels.Notification.Service
{
    public class Program
    {
        static ManualResetEvent resetEvent = new ManualResetEvent(false);
        public static void Main(string[] args) {
            var bus = BusConfigurator.ConfigureBus((cfg, host) => {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.NotificationServiceQueue
                    , e => {
                        e.Consumer<OrderRegisteredConsumer>();
                    });
            });

            Console.CancelKeyPress += (sender, eArgs) => {
                resetEvent.Set();
                eArgs.Cancel = true;
                bus.Stop();
            };


            Console.WriteLine("Listening for order registered event...");
            bus.Start();
            resetEvent.WaitOne();

        }
    }
}
