using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program<p1, p2>
    {
        public p1 demo { get; set; }
        public void Method(p1 P1, p2 P2)
        {
            Console.WriteLine($" p1: {P1}");
            Console.WriteLine($" p2: {P2}");
        }

    }
    class person { 
        static void Main(string[] args)
        {
            Program<string,int> program = new Program<string,int>();
            program.demo="infinite computer solutions";
            program.Method( "infinite",1033311);
            
           
        }
    }
}
