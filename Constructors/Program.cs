using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
       int x,y;
        //using constructors
        //parmeterized constructor
        internal Program(int x,int y)
        {

             this.x = x;
             this.y = y;
           
        }
        public void multiply()
        {
            int output = x * y;
            Console.WriteLine($"Multiplication of x and y is {output}");
        }
        static void Main(string[] args)
        {
            Program obj = new Program(20, 40);
            obj.multiply();


        }
    }
}
