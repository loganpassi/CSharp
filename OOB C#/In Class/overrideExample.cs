using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class mammal {

        public virtual void speak() {
        }
    }

    class moose : mammal {

        public override void speak()
        {
            Console.WriteLine("*moose noises*");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            moose myMoose = new moose();
            myMoose.speak();

        }
    }
}
