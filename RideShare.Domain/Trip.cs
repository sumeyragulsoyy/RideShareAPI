using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public string StartingStop { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int AvailableCapacity { get; set; }
        public bool IsTripActive { get; set; } = true;
        public bool IsTripFull { get; set; } = false;
    }
}
