using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public static class Menu
    {
        //public static List<string> Options { get; set; } = new List<string>();
        //public static string Title { get; set; }

        //public Menu(string title, List<string> options)
        //{
        //    Title = title;
        //    Options = options;
        //}

        public static int Display(string title, List<string> options)
        {
            Console.WriteLine(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
            Console.Write("Choose a valid option: ");
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
