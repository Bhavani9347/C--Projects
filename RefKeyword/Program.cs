using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refkeyword
{
    internal class Program
    {
        public void method1(ref int number)
        {

            number = number * 12;//any changes made to the variable inside the method will effect  the original variable passed to it
           
        }
        static void Main(string[] args)
        {

            int a = 4;
            Console.WriteLine(a);
            Program program = new Program();
            program.method1(ref a);///referencing the avalue to the method
            Console.WriteLine(a+1);//value will be modified

        }
    }
}
