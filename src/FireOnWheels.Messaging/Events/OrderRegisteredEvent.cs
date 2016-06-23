using System;
using FireOnWheels.Messaging.Commands;

namespace FireOnWheels.Messaging.Events
{
    public class OrderRegisteredEvent : IOrderRegisteredEvent
    {
        private readonly IRegisterOrderCommand _command;
        public OrderRegisteredEvent(IRegisterOrderCommand command, int id) {
            _command = command;
            OrderId = id;
        }

        public int OrderId { get; set; }
    }
}
