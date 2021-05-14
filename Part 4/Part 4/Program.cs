using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a fruit to find it's index (Apple, Kiwi, Tomato, Orange, Dragon Fruit).");
            string fruitSearch = Console.ReadLine();

            List<string> fruits = new List<string>() { "Apple", "Orange", "Dragon Fruit", "Tomato", "Kiwi" };
            bool matchFound = false;
            foreach (string fruit in fruits)
            {
                
                if (fruit == fruitSearch)
                {
                    matchFound = true;
                    Console.WriteLine(fruits.IndexOf(fruit));
                    break;
                }

            }
            if (matchFound == false)
            {
                Console.WriteLine("No match, try again.");
            }
            Console.ReadLine();
        }
    }
}
