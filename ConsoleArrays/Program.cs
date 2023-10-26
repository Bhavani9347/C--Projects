using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrays
{
    internal class Program
    {
        //using ref
        public static string Getnextname(ref int id)
        {
            string returnText = "Next -" + id.ToString();
            id += 1;
            return returnText;
        }

        static void Main(string[] args)
        {
           
            //using single dimensional array
            //int[] singledimension = { 4, 6, 8 };
            //Console.WriteLine(singledimension[2]);  
            //[4]Error "array index out of bounds "when array overflows this error arises
            // for(int i=0;i<singledimension.Length;i++)
            //{
            //   Console.WriteLine(singledimension[i]);
            //}

            /*using multidimensional arrays
            int[,] multidimensional = { { 10, 9, 8, 7 }, { 6, 5, 4, 3 } };
            Console.WriteLine(multidimensional[]);
            for(int i=0;i<multidimensional.Length;i++)
            {
                for(int j=0;j<multidimensional.Length;j++)
                {
                    Console.WriteLine(multidimensional[i,j]);
                }
            }*/

            //dynamic type
            /*dynamic d = 10;
            var result = d + 12;
            Console.Write($"The value of output is{result}");
            */

            //using ref
            int i = 1;
            Console.WriteLine("integer i:" + i.ToString());
            string test = Getnextname(ref i);
            Console.WriteLine("current value of i:" + i.ToString());
            
        }
        //Using out
        static void Main1(string[] args)
        {
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
