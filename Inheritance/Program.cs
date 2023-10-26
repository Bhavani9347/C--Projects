using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Parent
    {
        //base class
        public void basemethod()
        {
            Console.WriteLine("It is the base class");
        }
    }
    //derived class
    class Child : Parent
    {
        public void dervidemethod()
        {
            Console.WriteLine("It is the derived class where it inherits the characteristics and properties from base class");
        }
        static void Main(string[] args)
        {
            Parent obj = new Parent();
            obj.basemethod();
            Child obj1 = new Child();
            obj1.dervidemethod();
        }
    }
}
