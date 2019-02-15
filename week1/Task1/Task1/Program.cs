using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {

        static bool IsPrime(int n) //create function that can check number is prime or not
        {
            if (n == 1) return false; //if number is equal to 1,then number is not prime and return false
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false; //If number n can be divided by any other i, return false
            }
            return true; //in other situations return true

        }
        static void Main(string[] args)
        {
            string lineA = Console.ReadLine();
            int n = int.Parse(lineA); //number of elements in array
            string lineB = Console.ReadLine();
            string[] elem = lineB.Split(' '); //split numbers in array
            int c = 0;
            for (int i = 0; i < elem.Length; i++)
            {
                int x = Convert.ToInt32(elem[i]); //convert char to integer
                if (IsPrime(x)) c++;//if number is prime, then we add 1

            }
            Console.WriteLine(c); // number of prime numbers
            for (int i = 0; i < elem.Length; i++)
            {
                int x = Convert.ToInt32(elem[i]); //convert char to integer
                if (IsPrime(x))
                {
                    Console.Write(x);//if number is prime, we out put it
                    Console.Write(' ');
                }

            }

        }
    }
}
