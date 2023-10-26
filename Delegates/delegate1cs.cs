using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Arithematic(int x, int y);
    internal class delegate1cs
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int Subtraction(int x, int y) 
        { 
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            //referencing the delegate method
            Arithematic add = delegate1cs.Addition;
            Arithematic sub = delegate1cs.Subtraction;
            Arithematic mul = delegate1cs.Multiplication;


            int output = add(35, 42);
            int output1 = sub(95, 35);
            int output2 = mul(86, 52);

            Console.WriteLine($"The addition is {output} ");
            Console.WriteLine($"The substraction is {output1}");
            Console.WriteLine($"the multiplication is {output2}");
        }
    }
}
