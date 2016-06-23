using System;

namespace FireOnWheels.Messaging.Commands
{
    public interface IRegisterOrderCommand : ICommand
    {
        Guid CorrelationId { get; }
        string PickupName { get; }
        string PickupAddress { get; }
        string PickupCity { get; }
        string DeliveryName { get; }
        string DeliveryAddress { get; }
        string DeliveryCity { get; set; }

    }
}
