using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Operatoroverloading
{
    internal class Calculator
    {
        public int number = 0;
        public Calculator() { }//default constructor
        //parameterized constructor
        public Calculator(int n)
        {

            number = n; ;
        }
        //overloading of binary operator
        public static Calculator operator +(Calculator a, Calculator b)
        {
            Calculator c = new Calculator(0);
            c.number = a.number+ b.number;
            return c;
        }
        public void show()
        {
            Console.WriteLine("{0}", number);
        }
        static void Main(string[] args)
        {
            Calculator ob=new Calculator(100);
            Calculator ob1= new Calculator(200);
            Calculator ob2= new Calculator();

            ob2 = ob + ob1;
            ob.show();
            ob1.show();
            ob2.show();
            
        }
    }
}
