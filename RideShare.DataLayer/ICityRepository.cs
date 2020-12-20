using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.DataLayer
{
    public interface ICityRepository
    {
        City AddCity(City city);
        City GetCity(string name);
    }
}
