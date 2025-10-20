using CarRental.Abstracts;
using CarRental.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Truck : Vehicle
    {
        private int LoadCapacity {  get; set; }
        private int Axles { get; set; }

        public Truck(
            string model, 
            string make, 
            string licensePlate, 
            Kind kind, 
            string color, 
            int year,
            double dailyCost,
            int load,
            int axle
            ) 
        : base(
            model, 
            make, 
            licensePlate, 
            kind, 
            color, 
            year, 
            dailyCost
            )
        {
            this.LoadCapacity = load;
            this.Axles = axle;
        }
    }
}
