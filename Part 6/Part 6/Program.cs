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
            List<string> carBrands = new List<string>() { "Ford", "Chrysler", "Toyota", "Ford", "Nissan", "Nissan" };
            //the repeateBrand list is the empty list that will have the duplicates entered into it
            List<string> repeatBrand = new List<string>() { };

            foreach(string brand in carBrands)
            {
                bool one = true;
              
                for(int i = 0; i < repeatBrand.Count; i++)
                {//this loop will iterate through the duplicate list
                    
                    if(repeatBrand[i] == brand)
                    {
                        Console.WriteLine(brand + " is a duplicate");
                        one = false;
                    }

                }
                if(one == true)
                {// this will output what is a duplicate
                    Console.WriteLine("Brands: " + brand);
                }

                repeatBrand.Add(brand);

                one = true;
            }
            Console.ReadLine();
        }
    }
}
