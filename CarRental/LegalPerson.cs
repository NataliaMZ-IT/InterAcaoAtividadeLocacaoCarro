using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class LegalPerson : Person
    {
        private int Year;
        private string City;

        #region Setters
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetCity(string city)
        {
            City = city;
        }
        #endregion

        public override void ShowPerson()
        {
            Console.WriteLine("Company Name: " + GetName());
            Console.WriteLine("CNPJ: " + GetId());
            Console.WriteLine("Incorporation Year: " + Year);
            Console.WriteLine("Location (City): " + City);
        }
    }
}
