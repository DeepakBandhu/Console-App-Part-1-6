using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our contestants ages:\n");
            int[] ages = { 8, 9, 25, 17, 82, 34, 72, 21, 102 };
            //this determines which of the contestants are eligble
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] > 12)
                {
                    Console.WriteLine("Ages of contestants: " + ages[i]);
                }
            }
            Console.WriteLine("\nHere are some of their scores:\n");
            int[] playerScores = { 98, 80, 85, 73, 82, 55, 49, 50, 94 };
            //this determines which of ther scores are passing
            for (int i = 0; i + 1 <= playerScores.Length; i++)
            {
                if (playerScores[i] > 50)
                {
                    Console.WriteLine("Passing scores of some of the contestants: " + playerScores[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
