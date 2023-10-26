using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        int number = 10;
        public void method()
        {
            try
            {
                int result = number / 0;

            }
            catch
            {
                Console.WriteLine($"An error has been occured ");

            }
            finally
            {
                Console.WriteLine("The finally block will excute automatically");
            }
        }
      
        static void Main(string[] args)
        {
            Program program = new Program();
            program.method();
        }
    }
}
