using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.DataLayer
{
    public class TripRepository : ITripRepository
    {
        private readonly TripDbContext _context;

        public TripRepository(TripDbContext context )
        {
            _context = context;
        }
        public bool ChangeStatusTrip(int Id,bool tripStatus)
        {
            Trip trip = _context.Trips.Where(x => x.Id == Id).FirstOrDefault();
            trip.IsTripActive = tripStatus;
            _context.SaveChanges();
            return tripStatus;
        }

        public Trip CreateTrip(Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();
            return trip;
        }

        public List<Trip> getAvailableTripsAccordingToPoints(string From, string To)
        {
            List<Trip> availableTrips = _context.Trips.Where(x => x.IsTripActive == true && x.StartingStop == From && x.Destination == To).ToList();
            return availableTrips;
        }

        public Trip getTrip(int Id)
        {
            return _context.Trips.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool requestJoin(int TripId)
        {
            Trip trip = _context.Trips.Where(x => x.Id == TripId).FirstOrDefault();
            if (!trip.IsTripFull)
            {
                trip.AvailableCapacity--;
                if(trip.AvailableCapacity== 0)
                {
                    trip.IsTripFull = true;
                }
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

         
    }
}
