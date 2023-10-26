using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppoutkey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using out

            int i = 0;
            Console.WriteLine("previous value of integer i:" + i.ToString());
            string test = outexample(out i);
            Console.WriteLine("Current value of i :" + i.ToString());

        }
            public static string outexample(out int id)
            {
                id = 1;
                string returnText = "Next -" + id.ToString();
                return returnText;
            }
    }
}
