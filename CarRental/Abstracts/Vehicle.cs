using CarRental.Enumerators;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Abstracts
{
    public abstract class Vehicle
    {
        private Guid id {  get; set; } = Guid.NewGuid();
        private string Model {  get; set; }
        private string Make {  get; set; }
        private string LicensePlate { get; set; }
        private Kind Kind { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }
        private bool IsAvailable { get; set; } = true;
        public double DailyCost { get; set; }

        public Vehicle(
            string model, 
            string make, 
            string licensePlate, 
            Kind kind, 
            string color, 
            int year, 
            double dailyCost
            )
        {
            Model = model;
            Make = make;
            LicensePlate = licensePlate;
            Kind = kind;
            Color = color;
            Year = year;
            DailyCost = dailyCost;
        }
    }
}
