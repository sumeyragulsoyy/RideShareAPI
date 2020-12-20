using RideShareAPI.RideShare.DataLayer;
using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.Business
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }
        public bool ChangeStatusTrip(int Id, bool tripStatus)
        {
            return _tripRepository.ChangeStatusTrip(Id, tripStatus);
        }

        public Trip CreateTrip(Trip trip)
        {
            return _tripRepository.CreateTrip(trip);
        }

        public List<Trip> getAvailableTripsAccordingToPoints(string From, string To)
        {
            return _tripRepository.getAvailableTripsAccordingToPoints(From,To);
        }

        public Trip getTrip(int Id)
        {
            return _tripRepository.getTrip(Id);
        }

        public bool requestJoin(int TripId)
        {
            return _tripRepository.requestJoin(TripId);
        }
    }
}
