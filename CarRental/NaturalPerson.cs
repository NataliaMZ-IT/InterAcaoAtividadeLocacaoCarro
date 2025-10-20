using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class NaturalPerson : Person
    {
        private string Surname;
        private int Age;
        private char Sex;

        #region Setters
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetSex(char sex)
        {
            Sex = sex;
        }
        #endregion

        public override void ShowPerson()
        {
            Console.WriteLine($"Name: {GetName()} {Surname}");
            Console.WriteLine("CPF: " + GetId());
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Sex: " + Sex);
        }
    }
}
