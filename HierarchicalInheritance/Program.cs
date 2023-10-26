using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierrachicalInheritance
{
    //base class
    internal class ParentA
    {
        public void method1()
        {
            Console.WriteLine("This is the Hierarchical Inheritance of Parent:A");
        }
    }
    //derived class1 extends base class
    class childB:ParentA
    {
        public void method2()
        {
            Console.WriteLine("The first childclass:ChildB inherts the properties from ParentA class");
        }

    }
    //dervide class2 extends base class
    class childC:ParentA
    {
        public void method3()
        {
            Console.WriteLine("The second childclass:childC  inherts the properties from ParentA class");
        }
        static void Main(string[] args)
        {
            ParentA obj = new ParentA();
            obj.method1();
            childB obj1 = new childB();
            obj1.method2();
            childC obj2 = new childC();
            obj2.method3();
        }
    }
}
