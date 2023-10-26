using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    internal class Program
    {
       //Method overloading
       public void show(int a,int y)
        {
            Console.WriteLine("enter the values of a and y");
            //int res = Convert.ToInt16(Console.ReadLine());
            //int res1 = Convert.ToInt16(Console.ReadLine());
            int result = a + y;
            Console.WriteLine($"the values of a and y is {result}");
        }
        public void show2(float x,float y)
        {
            Console.WriteLine("ener the values of x ,y");
            float output = (x + y);
            Console.WriteLine($"the values of x and y is {output}");

        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.show(10,20);
            obj1.show2(6.47F,7.32F);

        }
    }
}
