using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.DataLayer
{
    public interface ITripRepository
    {
        Trip CreateTrip(Trip trip);
        bool ChangeStatusTrip(int Id,bool tripStatus);
        List<Trip> getAvailableTripsAccordingToPoints( string From, string To);
        bool requestJoin(int TripId);
        Trip getTrip(int Id);

    }
}
