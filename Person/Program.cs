using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModels()//object intializers
            {
                Name = "Abhi",
                Age = 21,
                Address = "JubilleHills No:123/456"
            };
            person.Driver();
            person.Study();
            person.Work();
        }

    }
}
 