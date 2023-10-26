using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
        public class Person
        {
            public string Name { get; set; }//properties of a person 
            public int Age { get; set; }
            public string Address { get; set; }
        }
        public interface IDriver
        {
            void Driver();
        }

        public interface IStudent
        {
            void Study();
        }

        public interface IEmployee
        {
            void Work();
        }
}
