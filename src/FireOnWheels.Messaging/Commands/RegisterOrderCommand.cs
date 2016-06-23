using System;

namespace FireOnWheels.Messaging.Commands
{
    public class RegisterOrderCommand : IRegisterOrderCommand
    {
        public RegisterOrderCommand(string pickupName, string pickupAddress
            ,string pickupCity, string deliveryName
            ,string deliveryAddress, string deliveryCity) {
            PickupName = pickupName;
            PickupAddress = pickupAddress;
            PickupCity = pickupCity;
            DeliveryName = deliveryName;
            DeliveryAddress = deliveryAddress;
            DeliveryCity = deliveryCity;
        }

        public Guid CorrelationId => Guid.NewGuid();
        public string PickupName { get;}
        public string PickupAddress { get; }
        public string PickupCity { get;}
        public string DeliveryName { get;}
        public string DeliveryAddress { get; }
        public string DeliveryCity { get; set; }
    }
}
