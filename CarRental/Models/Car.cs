using CarRental.Abstracts;
using CarRental.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car : Vehicle
    {
        private bool ManualGearbox {  get; set; }
        private int NumberOfPassengers { get; set; }

        public Car(
            string model, 
            string make, 
            string licensePlate, 
            Kind kind, 
            string color, 
            int year, 
            double dailyCost,
            bool gearbox,
            int passengers
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
            this.ManualGearbox = gearbox;
            this.NumberOfPassengers = passengers;
        }
    }
}
