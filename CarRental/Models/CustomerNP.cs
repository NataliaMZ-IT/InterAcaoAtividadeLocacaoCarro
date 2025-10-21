using CarRental.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class CustomerNP : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string CNH { get; set; }
        private string CPF { get; set; }

        public CustomerNP(
            string name, 
            DateOnly dateOfBirth, 
            Contact contact, 
            Address address, 
            string cnh, 
            string cpf
            ) 
        : base(
            name, 
            dateOfBirth, 
            contact, 
            address
            )
        {
            this.CNH = cnh;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()}\nCNH: {this.CNH}\nCPF: {this.CPF}";
        }
    }
}
