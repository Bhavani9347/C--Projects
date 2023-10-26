using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectintilalizer
{
    internal class Persondetails
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int age { get; set; }

        static void Main(string[] args)
        {
            Persondetails persondetails = new Persondetails
            {
                Name = "Shiva",
                Id = 1234,
                age = 20
            };
            Console.WriteLine(persondetails);

        }

    }

}
