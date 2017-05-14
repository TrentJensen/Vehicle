using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VehicleTracker.Models
{
    public class VehicleContext : DbContext
    {
        public VehicleContext (DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleTracker.Models.Vehicle> Vehicle { get; set; }
    }
}
