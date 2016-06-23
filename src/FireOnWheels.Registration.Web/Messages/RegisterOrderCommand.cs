using System;
using FireOnWheels.Messaging.Commands;
using FireOnWheels.Registration.Web.ViewModels;

namespace FireOnWheels.Registration.Web.Messages
{
    public class RegisterOrderCommand  : IRegisterOrderCommand
    {
        private readonly OrderViewModel viewModel;

        public RegisterOrderCommand(OrderViewModel model) {
            this.viewModel = model;
        }

        public Guid CorrelationId => Guid.NewGuid();
        public string PickupName => viewModel.PickupLocation.Contact;
        public string PickupAddress => viewModel.PickupLocation.Address;
        public string PickupCity => viewModel.PickupLocation.City;
        public string DeliveryName => viewModel.DestinationLocation.Contact;
        public string DeliveryAddress => viewModel.DestinationLocation.Address;

        public string DeliveryCity
        {
            get
            {
                return viewModel.DestinationLocation.City;
            }

            set
            {
                viewModel.DestinationLocation.City = value;
            }
        }
    }
}
