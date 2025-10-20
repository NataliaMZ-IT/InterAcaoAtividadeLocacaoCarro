using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Motorcycle : Vehicle
    {
        private int Seats;

        public Motorcycle()
        {
            IsRented = false;
        }

        public void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine("Number of Seats: " + Seats);
            Console.WriteLine($"Hourly Rate: ${GetHourlyCost():F2}");
            Console.WriteLine("Availability: " + (IsRented ? "Rented" : "Available"));
        }
    }
}
