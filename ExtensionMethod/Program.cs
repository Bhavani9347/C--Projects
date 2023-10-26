using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    internal static  class Program
    {
        public static int WordCount(this string s)//definition of extension
        {
                return s.Split(new char[] {' ', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            
        }
        public static int Count(this String s)
        {
            return s.Length;
            
        }
        static void Main(string[] args)
        {
            string s = "The topic is extension method";//assigning the value to the extension method
            int i = s.WordCount();
            int length = s.Count();
            Console.WriteLine(i);
            Console.WriteLine(length);
            
        }
    }
}


  