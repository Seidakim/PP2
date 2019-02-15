using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes;
            List<int> res = new List<int>();
            using (FileStream fs = new FileStream(@"D:\c#\lab2.txt", FileMode.Open, FileAccess.Read))// information about path
            {
                using (StreamReader ad = new StreamReader(fs))
                {
                    string text = ad.ReadLine();

                    int[] intnums = F(text);

                    for (int i = 0; i < intnums.Length; i++)//in this cycle we check prime numbers
                    {
                        if (IsPrime(intnums[i]))
                        {
                            res.Add(intnums[i]);

                        }
                        else continue;

                    }
                    primes = res.ToArray();


                }
            }
            using (FileStream gh = new FileStream(@"D:\c#\lab2output.txt", FileMode.Create, FileAccess.Write)) //create new file
            {
                using (StreamWriter v = new StreamWriter(gh))
                {
                    foreach (var x in primes)

                    {
                        v.Write(x + " "); //write prime numbers

                    }
                }

            }
        }
        private static int[] F(string text) //function that convert string to integer array
        {
            string[] parts = text.Split();
            int[] res = new int[parts.Length];
            for (int i = 0; i < parts.Length; ++i)
            {
                res[i] = int.Parse(parts[i]);
            }
            return res;
        }
        private static bool IsPrime(int n)//function that check number is prime or not
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
