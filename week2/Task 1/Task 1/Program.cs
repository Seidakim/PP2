using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\c#\lab1.txt", FileMode.Open, FileAccess.Read);//information about path
            StreamReader sd = new StreamReader(fs);

            string text = sd.ReadToEnd();
            int cnt = text.Length - 1; //counter
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)//time when program can not continue
                {
                    Console.WriteLine("Yes");
                    break;
                }

                if (text[i] == text[cnt])//check every symbol
                {
                    cnt--;
                    continue;
                }
                else
                {
                    Console.WriteLine("No"); // in other situations, it is not polindrome
                    break;
                }

            }
            sd.Close();
            fs.Close();
        }
    }
}
