using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class RentalSystem
    {
        public List<Person> Clients;
        public List<Vehicle> Vehicles;
        public List<Rental> Rentals;

        public RentalSystem()
        {
            Clients = new List<Person>();
            Vehicles = new List<Vehicle>();
            Rentals = new List<Rental>();
        }

        public void RentVehicle(Vehicle vehicle)
        {
            int index = Vehicles.FindIndex(v => v == vehicle);

            if (index != -1)
            {
                Vehicles[index].Rent();
            }
            else
            {
                Console.WriteLine("\nUnknown error has ocurred.");
            }
        }

        #region Verify Object Existence
        private bool VerifyClient(string ID)
        {
            if (Clients.Exists(c => c.GetId() == ID))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Client not registered!");
                return false;
            }
        }

        private bool VerifyVehicle(string ID)
        {
            if (Vehicles.Exists(v => v.GetLicensePlate() == ID))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Vehicle not registered!");
                return false;
            }
        }
        #endregion

        #region Register Objects
        private NaturalPerson RegisterNaturalPerson()
        {
            NaturalPerson person = new NaturalPerson();
            Console.Write("Insert first name: ");
            person.SetName(Console.ReadLine()!);
            Console.Write("Insert surname: ");
            person.SetSurname(Console.ReadLine()!);
            Console.Write("Insert CPF: ");
            person.SetId(Console.ReadLine()!);
            Console.Write("Insert age: ");
            person.SetAge(int.Parse(Console.ReadLine()!));
            Console.Write("Insert sex (F/M): ");
            person.SetSex(char.Parse(Console.ReadLine()!));
            return person;
        }

        private LegalPerson RegisterLegalPerson()
        {
            LegalPerson person = new LegalPerson();
            Console.Write("Insert company name: ");
            person.SetName(Console.ReadLine()!);
            Console.Write("Insert CNPJ: ");
            person.SetId(Console.ReadLine()!);
            Console.Write("Insert company incorporation year: ");
            person.SetYear(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the city the company is located in: ");
            person.SetCity(Console.ReadLine()!);
            return person;
        }

        private Motorcycle RegisterMotorcycle()
        {
            Motorcycle bike = new Motorcycle();
            Console.Write("Insert the make: ");
            bike.SetMake(Console.ReadLine()!);
            Console.Write("Insert the model: ");
            bike.SetModel(Console.ReadLine()!);
            Console.Write("Insert the year: ");
            bike.SetYear(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the license plate number: ");
            bike.SetLicensePlate(Console.ReadLine()!);
            Console.Write("Insert the color: ");
            bike.SetColor(Console.ReadLine()!);
            Console.Write("Insert the number of seats: ");
            bike.SetSeats(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the hourly rate charged for renting: ");
            bike.SetHourlyCost(double.Parse(Console.ReadLine()!));
            return bike;
        }

        private Car RegisterCar()
        {
            Car car = new Car();
            Console.Write("Insert the make: ");
            car.SetMake(Console.ReadLine()!);
            Console.Write("Insert the model: ");
            car.SetModel(Console.ReadLine()!);
            Console.Write("Insert the year: ");
            car.SetYear(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the license plate number: ");
            car.SetLicensePlate(Console.ReadLine()!);
            Console.Write("Insert the color: ");
            car.SetColor(Console.ReadLine()!);
            Console.Write("Insert the number of doors: ");
            car.SetDoors(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the hourly rate charged for renting: ");
            car.SetHourlyCost(double.Parse(Console.ReadLine()!));
            return car;
        }

        private Truck RegisterTruck()
        {
            Truck truck = new Truck();
            Console.Write("Insert the make: ");
            truck.SetMake(Console.ReadLine()!);
            Console.Write("Insert the model: ");
            truck.SetModel(Console.ReadLine()!);
            Console.Write("Insert the year: ");
            truck.SetYear(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the license plate number: ");
            truck.SetLicensePlate(Console.ReadLine()!);
            Console.Write("Insert the color: ");
            truck.SetColor(Console.ReadLine()!);
            Console.Write("Insert the weight capacity in kg: ");
            truck.SetWeightCapacity(int.Parse(Console.ReadLine()!));
            Console.Write("Insert the hourly rate charged for renting: ");
            truck.SetHourlyCost(double.Parse(Console.ReadLine()!));
            return truck;
        }
        #endregion

        #region Add Objects to Lists
        public void AddClient(int option)
        {
            if (option == 1)
            {
                Clients.Add(RegisterNaturalPerson());
            }
            else if (option == 2)
            {
                Clients.Add(RegisterLegalPerson());
            }
            else
            {
                Console.WriteLine("\nInvalid option. Cancelling operation-");
            }
        }

        public void AddVehicle(int option)
        {
            if (option == 1)
            {
                Vehicles.Add(RegisterMotorcycle());
            }
            else if (option == 2)
            {
                Vehicles.Add(RegisterCar());
            }
            else if (option == 3)
            {
                Vehicles.Add(RegisterTruck());
            }
            else
            {
                Console.WriteLine("\nInvalid option. Cancelling operation-");
            }
        }

        public void AddRental()
        {
            Console.Write("Insert the CPF or CNPJ of the client: ");
            string clientID = Console.ReadLine()!;
            Console.Write("Insert the license plate of the desired vehicle: ");
            string vehicleID = Console.ReadLine()!;

            if (VerifyClient(clientID) & VerifyVehicle(vehicleID))
            {
                Vehicle vehicle = Vehicles.Find(v => v.GetLicensePlate() == vehicleID)!;
                if (vehicle.IsRented)
                {
                    Console.WriteLine("Vehicle is already being rented out!");
                }
                else
                {
                    Console.Write("Insert the amount of time (in hours) the vehicle will be rented for: ");
                    int hours = int.Parse(Console.ReadLine()!);
                    Person client = Clients.Find(c => c.GetId() == clientID)!;
                    Rentals.Add(new Rental(client, vehicle, hours));

                    RentVehicle(vehicle);
                }
            }
        }
        #endregion

        #region Show Info of Lists
        public void ShowList(List<Person> list)
        {
            Console.WriteLine("----------List of Clients----------");
            foreach (var item in list)
            {
                item.ShowPerson();
                Console.WriteLine();
            }
        }

        public void ShowList(List<Vehicle> list)
        {
            Console.WriteLine("----------List of Vehicles----------");
            foreach (var item in list)
            {
                item.ShowVehicle();
                Console.WriteLine();
            }
        }

        public void ShowList(List<Rental> list)
        {
            Console.WriteLine("----------List of Vehicles----------");
            foreach (var item in list)
            {
                item.ShowRental();
                Console.WriteLine();
            }
        }
        #endregion
    }
}
