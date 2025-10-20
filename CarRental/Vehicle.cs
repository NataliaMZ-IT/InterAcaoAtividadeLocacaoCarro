using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public abstract class Vehicle
    {
        private string Make;
        private string Model;
        private string Color;
        private int Year;
        private string LicensePlate;
        private double HourlyCost;
        public bool IsRented { get; set; }

        #region Getters and Setters
        public void SetMake(string make)
        {
            Make = make;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public string GetModel()
        {
            return Model;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetLicensePlate(string licensePlate)
        {
            LicensePlate = licensePlate;
        }
        public string GetLicensePlate()
        {
            return LicensePlate;
        }
        public void SetHourlyCost(double hourlyCost)
        {
            HourlyCost = hourlyCost;
        }
        public double GetHourlyCost()
        {
            return HourlyCost;
        }
        #endregion

        public void Rent()
        {
            this.IsRented = true;
        }

        public virtual void ShowVehicle()
        {
            Console.WriteLine($"Vehicle: {Make} {Model} {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"License Plate: {LicensePlate}");
        }
    }
}
