using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Person.Interface;
//using System.Xml.Linq;

namespace Person
{
    public class PersonModels : Person, IDriver, IStudent, IEmployee
    {
        public void Driver()
        {
            Console.WriteLine($"The driving one name is {Name}");
            Console.WriteLine($"The age of the driver is {Age} old");
            Console.WriteLine($"Address of the driver is {Address}");
        }
        public void Study()
        {
            Console.WriteLine($"{Name} is currently studying");
        }
        public void Work()
        {
            Console.WriteLine($"The Working one is {Name}");
        }
    }

}

 
       




