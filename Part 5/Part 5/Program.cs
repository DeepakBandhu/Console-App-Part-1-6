using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Deepak", "Joe", "Zach", "Deepak", "Ashely", "Maddy", "Ashley" };
            bool nameFound = false;

            Console.WriteLine("Type either Deepak, Zach, Maddy, Joe, or Ashely to find out their position in the list.");
            string nameType = Console.ReadLine();

            foreach (string name in names)
            {

                if (name == nameType)
                {
                    nameFound = true;
                    Console.WriteLine(names.IndexOf(name));
                    break;
                }

            }
            if (nameFound == false)
            {
                Console.WriteLine("That name is unavailable, please enter a name that is on the list.");
            }
            Console.ReadLine();

        }
    }
}
