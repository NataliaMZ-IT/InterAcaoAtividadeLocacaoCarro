// Locação de Veículos
using CarRental;

RentalSystem system = new RentalSystem();

int op, aux;
do
{
    Console.WriteLine("\n------------------------------------");
    Console.WriteLine("Choose an option:" +
        "\n1 - Register Client" +
        "\n2 - Register Vehicle" +
        "\n3 - Rent a Vehicle" +
        "\n4 - Return a Vehicle" +
        "\n5 - Show All Clients" +
        "\n6 - Show All Vehicles" +
        "\n7 - Show All Rental Contracts" +
        "\n0 - Exit");
    Console.WriteLine("------------------------------------");
    op = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (op)
    {
        case 0:
            Console.WriteLine("Exiting program...");
            break;
        case 1:
            Console.WriteLine("What kind of client would you like to register?\n1 - Natural Person\n2 - Legal Person");
            aux = int.Parse(Console.ReadLine()!);
            system.AddClient(aux);
                break;
        case 2:
            Console.WriteLine("What kind of vehicle would you like to register?\n1 - Motorcycle\n2 - Car\n3 - Truck");
            aux = int.Parse(Console.ReadLine()!);
            system.AddVehicle(aux);
            break;
        case 3:
            system.AddRental();
            break;
        case 4:
            system.RemoveRental();
            break;
        case 5:
            system.ShowList(system.Clients);
            break;
        case 6:
            system.ShowList(system.Vehicles);
            break;
        case 7:
            system.ShowList(system.Rentals);
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
} while (op != 0);