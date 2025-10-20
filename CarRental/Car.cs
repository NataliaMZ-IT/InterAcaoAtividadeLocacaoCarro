using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car : Vehicle
    {
        private int Doors;

        public Car()
        {
            IsRented = false;
        }

        public void SetDoors(int doors)
        {
            Doors = doors;
        }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine("Number of Doors: " + Doors);
            Console.WriteLine($"Hourly Rate: ${GetHourlyCost():F2}");
            Console.WriteLine("Availability: " + (IsRented ? "Rented" : "Available"));
        }
    }
}
