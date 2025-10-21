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

        public override string ToString()
        {
            return $"{base.ToString()}\nType of Gearbox: " + (this.ManualGearbox ? "Manual" : "Automatic") +
                $"\nMax. Number of Passengers: {this.NumberOfPassengers}" +
                $"\nDaily Cost: {this.DailyCost}" +
                $"\nAvailability: " + (this.GetAvailability() ? "Yes" : "No");
        }
    }
}
