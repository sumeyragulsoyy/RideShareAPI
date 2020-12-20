using Microsoft.AspNetCore.Mvc;
using RideShareAPI.RideShare.Business;
using RideShareAPI.RideShare.Domain;
using RideShareAPI.RideShare.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.API
{
    [Route("[Controller]")]
    [ApiController]
    public class RideShareController : ControllerBase
    {
        private readonly ITripService _tripService;

        public RideShareController(ITripService tripService)
        {
            _tripService = tripService;
        }


        [HttpPost("ChangeStatus")]
        public  IActionResult ChangeStatusTrip(ChangeTripStatusRequest request )
        {
           return Ok( _tripService.ChangeStatusTrip(request.Id, request.tripStatus));
        }

        [HttpPost("CreateTrip")]
        public IActionResult CreateTrip(Trip trip)
        {
            return Ok( _tripService.CreateTrip(trip));
        }

        [HttpGet("GetAvailableTrips")]       
        public IActionResult GetAvailableTripsAccordingToPoints(AvailableTripsRequest request)
        {
            return Ok( _tripService.getAvailableTripsAccordingToPoints(request.StartingStop,request.Destination));
        }

        [HttpGet("{id}")]
        public IActionResult GetTrip(int Id)
        {
            return Ok( _tripService.getTrip(Id));
        }

        [HttpPost("Join")]
        public IActionResult RequestJoin(JoinRequest request)
        {
            return Ok( _tripService.requestJoin(request.Id));
        }
    }
}
