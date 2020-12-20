using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.DataLayer
{
    public class CityRepository : ICityRepository
    {
        private readonly TripDbContext _context;

        public CityRepository(TripDbContext context)
        {
            _context = context;
        }
        public City AddCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }

        public City GetCity(string name)
        {
            City city = _context.Cities.Where(x => x.Name == name).FirstOrDefault();
            return city;
        }
    }
}
