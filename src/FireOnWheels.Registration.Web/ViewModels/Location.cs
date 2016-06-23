using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FireOnWheels.Registration.Web.ViewModels
{
    public class Location
    {
        [Key]
        public int Key { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
