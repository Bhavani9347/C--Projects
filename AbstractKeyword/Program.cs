using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Abstract.abstractchild;

namespace abstractkeyword
{
    internal class Programz
    {
       static void Main(string[] args)
        {
            abstractchild.RoadLines ob = new abstractchild.RoadLines();
            Console.WriteLine(ob.Mode("Cab"));
            ob.show();
        }
    }
}
