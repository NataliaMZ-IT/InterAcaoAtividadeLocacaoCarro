using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Truck : Vehicle
    {
        private int WeightCapacity;

        public Truck()
        {
            IsRented = false;
        }

        public void SetWeightCapacity(int weightCapacity)
        {
            WeightCapacity = weightCapacity;
        }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine("Weight Capacity: " + WeightCapacity);
            Console.WriteLine($"Hourly Rate: ${GetHourlyCost():F2}");
            Console.WriteLine("Availability: " + (IsRented ? "Rented" : "Available"));
        }
    }
}
