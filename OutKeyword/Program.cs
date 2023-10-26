using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outkeyword
{
    internal class Program
    {
        public void Main(out int number)
        {
            number = 4;//Initializing the value
        }
        static void Main(string[] args)
        {
            int x;
            Program program = new Program();
            program.Main(out x);//just declared 
            Console.WriteLine(x);//

        }
    }
}
