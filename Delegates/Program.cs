using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void delegatedemo(String text);
        //delegate method
        public static void DelegateMethod(String text)
        {
            Console.WriteLine(text);
        }
       /* static void Main(string[] args)
        {
            //Instantiating the delegate 
            delegatedemo handler = DelegateMethod;
            //calling the delegate
            handler("Hello World");


            //referencing the delegate method
            Arithematic add = delegate1cs.Addition;
            Arithematic sub = delegate1cs.Subtraction;
            Arithematic mul = delegate1cs.Multiplication;
      }*/
    }
}
