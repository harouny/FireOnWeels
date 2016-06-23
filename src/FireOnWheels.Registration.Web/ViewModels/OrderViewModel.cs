using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FireOnWheels.Registration.Web.ViewModels
{
    public class OrderViewModel
    {
        [Key]
        public int OrderId { get; set; }
        public Location PickupLocation { get; set; }
        public Location DestinationLocation { get; set; }
        public decimal PackageWeight { get; set; }
        public bool IsFragile { get; set; }
        public bool IsOversized { get; set; }

    }
}
