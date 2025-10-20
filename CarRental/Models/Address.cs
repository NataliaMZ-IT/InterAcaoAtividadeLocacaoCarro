using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Address
    {
        private string Street { get; set; }
        private int Number { get; set; }
        private string Neighborhood { get; set; } = String.Empty;
        private string ZipCode { get; set; }
        private string? Complement { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string? Country { get; set; } = String.Empty;

        public Address(
            string street,
            int number, 
            string neighborhood,
            string zipCode, 
            string? complement,
            string city, 
            string state,
            string? country
            )
        {
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.ZipCode = zipCode;
            this.Complement = complement;
            this.City = city;
            this.State = state;
            this.Country = country;
        }

        public override string ToString()
        {
            return $"\nStreet Address: {Street}, {Number}\n" + 
            $"Neighborhood: {Neighborhood}\n" +
            $"ZIP: {ZipCode}\n" +
            $"Complement: {Complement}\n" +
            $"City/State: {City}, {State}\n" +
            $"Country: {Country}";
        }
    }
}
