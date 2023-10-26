using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    //base class or parent class
    internal class Parent
    {
        public virtual void method1(string name,int emplid)
        {
            Console.WriteLine("It is the base class ");
            Console.WriteLine($"The name of the company is {name}, and the employeeid is {emplid}");
        }
       
        //Derived class or child class :overriden takes places
        class child:Parent
        {
            public override void method1(string name,int age)
            {
                Console.WriteLine("It is the child class");
                Console.WriteLine($"The name is {name}, and the age is {age}");
            }

        }
        static void Main(string[] args)
        {

          /* Parent parent = new Parent();
           parent.method1("Infinite computer solutions", 1033311);
            child obj= new child();
            obj.method1("Bhavani", 21);*/

            Parent obj1= new child();
            obj1.method1("Bhavani", 21);
            Parent obj2 = new child ();
            obj2.method1("abhi", 1033311);

        }
    }
}
