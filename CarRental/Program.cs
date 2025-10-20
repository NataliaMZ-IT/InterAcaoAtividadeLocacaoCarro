// Locação de Veículos
using CarRental.Abstracts;
using CarRental.Entities;
using CarRental.Models;

RentalCompany rentalCompany = new RentalCompany();

List<string> mainOptions = new List<string>()
{
    "Customer Menu",
    "Vehicle Menu",
    "Rental Menu",
    "Exit"
};

List<string> customerOptions = new List<string>()
{
    "Register Customer",
    "List Customers",
    "Update Customer",
    "Remove Customer",
    "Return to Main Menu"
};

List<string> vehicleOptions = new List<string>()
{
    "Register Vehicle",
    "List Vehicles",
    "Modify Vehicle",
    "Remove Vehicle",
    "Return to Main Menu"
};

List<string> rentalOptions = new List<string>()
{
    "Register Vehicle",
    "List Rentals",
    "Finalize Rental",
    "Remove Rental",
    "Return to Main Menu"
};

void CreateCustomer()
{
    Console.Write("\nInform the customer's name: ");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine("Informe the customer's date of birth: ");
    DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine() ?? "");
    Console.Write("Informe the customer's email: ");
    string email = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's street address: ");
    string street = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's street address number: ");
    int number = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Inform the customer's address compliment: ");
    string complement = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's neighborhood: ");
    string neighborhood = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's city: ");
    string city = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's state: ");
    string state = Console.ReadLine() ?? "";
    Console.Write("Inform the customer's ZIP-code: ");
    string zipCode = Console.ReadLine() ?? "";

    var contact = new Contact(email, null);
    var address = new Address(street, number, neighborhood, zipCode, complement, city, state, "Brazil");

    Console.WriteLine("What type of customer is being registered? (1 for Natural Person, 2 for Legal Person): ");
    int customerType = int.Parse(Console.ReadLine() ?? "1");
    if (customerType == 1)
    {
        Console.Write("Inform the customer's CNH number: ");
        string cnh = Console.ReadLine() ?? "";
        Console.Write("Inform the customer's CPF number: ");
        string cpf = Console.ReadLine() ?? "";
        var customer = new CustomerNP(name, dateOfBirth, contact, address, cnh, cpf);
        rentalCompany.Customers.Add(customer);
    }
    else
    {
        Console.Write("Inform the customer's CNPJ number: ");
        string cnpj = Console.ReadLine() ?? "";
        var customer = new CustomerLP(name, dateOfBirth, contact, address, cnpj);
        rentalCompany.Customers.Add(customer);
    }
}

void ListCustomers()
{
    Console.WriteLine("\n=== Customer List ===");
    foreach (var customer in rentalCompany.Customers)
    {
        Console.WriteLine(customer);
        //Console.WriteLine(customer.ToString());
    }
}

Person? FindCustomerByName(string name)
{
    return rentalCompany.Customers.Find(c => c.GetName() == name);

}

Person? UpdatePhone()
{
    Console.WriteLine("\nInform the name of the customer that is to be updated: ");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        Console.WriteLine("Inform the customer's phone number: ");
        string phone = Console.ReadLine() ?? "";
        customer.SetContactPhone(phone);
        Console.WriteLine("Customer's phone number sucessfully updated.");
    }
    else
    {
        Console.WriteLine("Customer not found.");
    }
    return customer;
}

void DeleteCustomer()
{
    Console.WriteLine("\nInform the name of the customer that is to be removed: ");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        rentalCompany.Customers.Remove(customer);
        Console.WriteLine("Customer sucessfully removed.");
    }
    else
    {
        Console.WriteLine("Customer not found.");
    }
}

void CustomerMenu(int option)
{
    switch (option)
    {
        case 1:
            CreateCustomer();
            break;
        case 2:
            ListCustomers();
            break;
        case 3:
            Console.WriteLine(UpdatePhone());
            break;
        case 4:
            DeleteCustomer();
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Invalid option! Try again.");
            break;
    }
}

do
{
    int mainChoice = Menu.Display("\n=== Main Menu ===", mainOptions);

    switch (mainChoice)
    {
        case 1:
            int customerChoice = Menu.Display("\n=== Customer Menu ===", customerOptions);
            CustomerMenu(customerChoice);
            break;
        case 2:
            int vehicleChoice = Menu.Display("\n=== Vehicle Menu ===", vehicleOptions);
            break;
        case 3:
            int rentalChoice = Menu.Display("\n=== Rental Menu ===", rentalOptions);
            break;
        case 4:
            Console.WriteLine("Exiting program...");
            break;
        default:
            Console.WriteLine("Invalid option! Try again.");
            break;
    }
} while (true);