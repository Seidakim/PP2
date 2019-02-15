using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student //create class
    {
        string Name;
        string Id;
        int Year;
        public Student(string n, string i)//create student constructor
        {
            Name = n;
            Id = i;
            Year = 2019;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Student: {0}; Id: {1}", Name, Id); //output method
            Console.WriteLine(++Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("Omarov", "4.0"); //create and give information about student
            s.PrintInfo();

        }
    }
}
