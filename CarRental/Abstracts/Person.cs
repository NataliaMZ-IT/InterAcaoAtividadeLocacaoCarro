using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Abstracts
{
    public abstract class Person
    {
        private string Name { get; set; }
        private DateOnly DateOfBirth { get; set; }
        private Contact Contact { get; set; }
        private Address Address { get; set; }

        public Person(string name, DateOnly dateOfBirth, Contact contact, Address address)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Contact = contact;
            Address = address;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetContactPhone(string phone)
        {
            this.Contact.SetPhone(phone);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDateOfBirth: {DateOfBirth}\n\tContact: {Contact}\n\tAddress: {Address}";
        }
    }
}
