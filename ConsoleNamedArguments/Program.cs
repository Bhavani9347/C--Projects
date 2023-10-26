using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolenamedaruguments
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //namedaruguments(age:22, name: "bhavani",employeeid:1033311);
            //namedaruguments1("bhavani");
            //namedaruguments1("bhavani", 30);
            namedaruguments3("bhavani",44444,21);
        }

        // using named aruguments
        static void namedaruguments(string name,int employeeid ,int age)
        {
            Console.WriteLine($"the name is :{name},and the employeeid is:{employeeid},then the age is {age}");
        }

        //using optional parameter
        static void namedaruguments1(string name, int employeeid =0, int age=0)
        {
            Console.WriteLine($"the name is :{name},and the employeeid is:{employeeid},then the age is {age}");
        }

        //using positional parameter
        static void namedaruguments3(string name, int employeeid, int age)
        {
            Console.WriteLine($"the name is :{name},and the employeeid is:{employeeid},then the age is {age}");
        }
    }
}
