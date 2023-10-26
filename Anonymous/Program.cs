using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    internal class Anonymous
    {
        public void Anonymousdemo()
        {
            var s = new 
            {
                Amount = 100 ,
                Message="Have a nice day"
            };
            Console.WriteLine(s.Amount + s.Message);
        }
        static void Main(string[] args)
        {
            Anonymous obj = new Anonymous();
                obj.Anonymousdemo();
        }
    }
}
