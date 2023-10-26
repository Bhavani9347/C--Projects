using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance
{
    //base class
    internal class A
    {
        public void method1()
        {
            Console.WriteLine("The parent class is A");
        }
    }
    //derived class B extends A
    class B:A 
    {
        public void method2()
        {
            Console.WriteLine("The child class B inherits the properties from A parent class");
        }
    }

    //derived class C extends B 
    class C : B
    {
        public void method3()
        {
            Console.WriteLine("The child class C inherits the properties from parent class B");

        }


        static void Main(string[] args)
        {
            A objA = new A();
            objA.method1();
            B object2 = new B();
            object2.method2();
            C object3 = new C();
            object3.method3();


        }
    }
}
