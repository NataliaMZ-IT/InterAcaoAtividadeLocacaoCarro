using CarRental.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class CustomerLP : Person
    {
        private Guid Id {  get; set; } = Guid.NewGuid();
        private string CNPJ {  get; set; }

        public CustomerLP(
            string name, 
            DateOnly dateOfBirth, 
            Contact contact, 
            Address address, 
            string cnpj
            ) 
        : base(
            name, 
            dateOfBirth, 
            contact, 
            address
            )
        {
            this.CNPJ = cnpj;
        }

        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()}\nCNPJ: {this.CNPJ}";
        }
    }
}
