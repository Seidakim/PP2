using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineA = Console.ReadLine();
            string lineB = Console.ReadLine();
            int n = int.Parse(lineA); //number of elements in array
            string[] s = lineB.Split(' '); //split numbers in array
            int[] x = new int[n * 2]; //create new array 
            int f = -1; //counter of new array in cycle
            for (int i = 0; i < n; i++)
            {
                int c = Convert.ToInt32(s[i]); //convert char to integer
                x[++f] = c; //elements of second array
                x[++f] = c;

            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]); //output 
                Console.Write(' ');
            }
        }
    }
}
