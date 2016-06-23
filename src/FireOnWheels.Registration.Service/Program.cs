using System;
using System.Threading;
using FireOnWheels.Messaging;
using MassTransit;

namespace FireOnWheels.Registration.Service
{
    public class Program
    {
        static ManualResetEvent resetEvent = new ManualResetEvent(false);
        public static void Main(string[] args) {

            var bus = BusConfigurator.ConfigureBus((cfg, host) => {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.RegisterOrderServiceQueue
                    , e => {
                        e.Consumer<RegisteredOrderCommandConsumer>();
                    });
            });

            Console.CancelKeyPress += (sender, eArgs) => {
                resetEvent.Set();
                eArgs.Cancel = true;
                bus.Stop();
            };

            Console.WriteLine("Listening for register order command...");
            bus.Start();
            resetEvent.WaitOne();

        }
    }
}
