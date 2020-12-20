using Microsoft.EntityFrameworkCore;
using RideShareAPI.RideShare.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideShareAPI.RideShare.DataLayer
{
    public class TripDbContext :DbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
