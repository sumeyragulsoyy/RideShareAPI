using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OriginX { get; set; }
        public int OriginY { get; set; }

    }
}
