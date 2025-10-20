using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Rental
    {
        public Person Client {  get; set; }
        public Vehicle Vehicle { get; set; }
        public int Hours { get; set; }

        public Rental(Person client, Vehicle vehicle, int hours)
        {
            this.Client = client;
            this.Vehicle = vehicle;
            this.Hours = hours;
        }

        private double CalculateTotalCost()
        {
            return (this.Hours * this.Vehicle.GetHourlyCost());
        }

        public void ShowRental()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Client: {this.Client.GetName()}");
            Console.WriteLine($"Vehicle: {this.Vehicle.GetModel()} | License Plate: {this.Vehicle.GetLicensePlate()}");
            Console.WriteLine($"Hours: {this.Hours}");
            Console.WriteLine($"Total Cost: ${CalculateTotalCost():F2}");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("\t\t\tDetails");
            Console.WriteLine("- Client");
            this.Client.ShowPerson();
            Console.WriteLine("- Vehicle");
            this.Vehicle.ShowVehicle();
        }
    }
}
