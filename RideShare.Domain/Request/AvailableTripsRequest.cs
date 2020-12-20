using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.Domain.Request
{
    public class AvailableTripsRequest
    {
        public string StartingStop { get; set; }
        public string Destination { get; set; }
    }
}
