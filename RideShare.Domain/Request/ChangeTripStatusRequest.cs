using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.Domain.Request
{
    public class ChangeTripStatusRequest
    {
        public int Id { get; set; }
        public bool tripStatus { get; set; }
        
    }
}
