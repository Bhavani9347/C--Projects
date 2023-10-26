using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int>square= x => x * x;
            int output = square(7);
            Console.WriteLine($"The sqaure of 7 is {output}");
        }
    }
}
