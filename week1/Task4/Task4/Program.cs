using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineA = Console.ReadLine();

            int n = int.Parse(lineA); //number of elements in array
            int[,] arr = new int[n, n]; //create 2D array
            for (int i = 0; i < n; i++) //create cycle from 0 to number of elements in array
            {
                for (int j = 0; j < i + 1; j++) //create cycle that the length of which 
                                                //increases depending on the first array
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
