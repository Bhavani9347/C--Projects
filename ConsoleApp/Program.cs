using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");
           // Console.Write("It is introduced in 2022");
            //Console.WriteLine("\n Enter your Employeeid:");
           // int Employeeid = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"The employeeid is {Employeeid}");
            Console.WriteLine("Mention your companyname and location");
            String companyname = Console.ReadLine();
            String location = Console.ReadLine();
            Console.WriteLine($"My company is {companyname}, {location}");
           // Console.WriteLine($"The location of my company is {location}");

        }
    }
}

