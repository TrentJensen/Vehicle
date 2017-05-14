using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Models
{
    public class Vehicle
    {
        /// <summary>
        /// Primary key ID of Vehicle
        /// </summary>
        public int VehicleID { get; set; }

        public enum VehicleType
        {
            [Display(Name = "Car")]
            Car,
            [Display(Name = "Truck")]
            Truck,
            [Display(Name = "Motorcycle")]
            Motorcycle,
            [Display(Name = "Boat")]
            Boat
        }
             
        /// <summary>
        /// Type of vehicle (car, truck, etc.)
        /// </summary>
        public VehicleType Type { get; set; }

        /// <summary>
        /// How much gas the car currently has
        /// </summary>
        public double GasAmount { get; set; }

        /// <summary>
        /// Number of tires on the vehicle
        /// </summary>
        public int TiresNum { get; set; }
    }
}
