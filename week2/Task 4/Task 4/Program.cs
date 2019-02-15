using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"D:\c#\path\task4.txt", FileMode.Create)) { } //create file

            string fileName = "task4.txt";
            string path = @"D:\c#\path";//path of directory
            string path1 = @"D:\c#\path1";//path of directory

            string Ffile = Path.Combine(path, fileName);  //combine path and file
            string Sfile = Path.Combine(path1, fileName); //combine path and file


            File.Copy(Ffile, Sfile);//copy file
            File.Delete(@"D:\c#\path\task4.txt"); //delete file
        }
    }
}
