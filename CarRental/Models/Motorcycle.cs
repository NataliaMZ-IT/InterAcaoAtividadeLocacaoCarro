using CarRental.Abstracts;
using CarRental.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Motorcycle : Vehicle
    {
        private int EngineCapacity {  get; set; }
        private int NumberOfPassengers { get; set; }

        public Motorcycle(
            string model, 
            string make, 
            string licensePlate, 
            Kind kind, 
            string color, 
            int year, 
            double dailyCost,
            int engine,
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
            this.EngineCapacity = engine;
            this.NumberOfPassengers = passengers;
        }
    }
}
