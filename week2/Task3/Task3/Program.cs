using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo fd = new DirectoryInfo(@"D:\Forza horizon"); //information about directory path
            PrintInfo(fd, 0);
        }
        static void PrintInfo(FileSystemInfo f1, int k) //function that show files in directory
        {
            string s = new string(' ', k);
            Console.WriteLine(s + f1.Name);

            if (f1.GetType() == typeof(DirectoryInfo))//check it is directory or not
            {
                FileSystemInfo[] arr = ((DirectoryInfo)f1).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; i++)
                {
                    PrintInfo(arr[i], k + 3);
                }
            }
        }
    }
}
