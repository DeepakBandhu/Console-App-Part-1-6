using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Deepak", "Ashely", "Michael", "Brooke" };

            Console.WriteLine("Input whatever text you would like.");
            string userInput = Console.ReadLine();

            //foreach (string name in names)
            //{
            //    string named = names + userInput;
            //}

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " " +userInput + ".");
            }
            Console.ReadLine();
        }
        

    }
}
