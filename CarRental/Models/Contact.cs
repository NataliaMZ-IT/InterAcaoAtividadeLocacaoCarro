using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Contact
    {
        private string Email { get; set; }
        private string? Phone { get; set; }

        public Contact(string email, string? phone)
        {
            this.Email = email;
            this.Phone = phone;
        }

        public void SetPhone(string phone)
        {
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"Email: {this.Email}\nPhone: {this.Phone}";
        }
    }
}
