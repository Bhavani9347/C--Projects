using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodhiding1
{
    public class show
    {

        public void display()
        {
            Console.WriteLine("Hello");
        }
    }
    /*class show1 : show
        {
        public override void display()
        {
            Console.WriteLine("Hiding the text");
        }
    }*/
    class show1:show

    {
        public new void display()
        {
            Console.WriteLine("It is overrided derived class method");
        }
    }

}
