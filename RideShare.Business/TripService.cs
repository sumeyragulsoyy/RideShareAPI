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
        private readonly ICityRepository _cityRepository;

        public TripService(ITripRepository tripRepository,ICityRepository cityRepository)
        {
            _tripRepository = tripRepository;
            _cityRepository = cityRepository;
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

        public List<Trip> GetAllTripsBetweenPoints(string From,string To)
        {
            City startingPoint = _cityRepository.GetCity(From);
            City destination = _cityRepository.GetCity(To);

            List<Trip> allTrips = _tripRepository.GetAllTripsBetweenPoints();
            List<Trip> betweenPoints = new List<Trip>();
            foreach(Trip trip in allTrips)
            {
                City startCity = _cityRepository.GetCity(trip.StartingStop);
                City endCity = _cityRepository.GetCity(trip.Destination);
                if((startingPoint.OriginX <= startCity.OriginX && startCity.OriginX <= endCity.OriginX) &&
                    (startingPoint.OriginY <=startCity.OriginY && startCity.OriginY <= endCity.OriginY))
                {
                    betweenPoints.Add(trip);
                }
            }
            return betweenPoints;
        }

    }
}
