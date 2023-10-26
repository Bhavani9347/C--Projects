using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countcharacters
{
    internal static class Program
    {
        public static int wordCount(this string)
        {

        }
        static void Main(string[] args)
        {
            string s = "Welcome";
            int result = s.wordCount();
            Console.WriteLine(result);
        }
    }
}
