using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carBrands = new List<string>() { "Ford", "Chrysler", "Toyota", "Ford", "Ford", "Nissan", "Nissan" };

            foreach(string brand in carBrands)
            {
                Console.WriteLine("Brands: " + brand);
            }

            Console.ReadLine();
        }
    }
}
