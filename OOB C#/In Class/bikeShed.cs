using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shed {
        private string shedColor;

        public string Color {

            get { return shedColor; }
            set { shedColor = value; }
        }
    }

    class bikeShed : Shed {

        public override string ToString()
        {
            return $"The color of my shed is {Color}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            bikeShed shed1 = new bikeShed();
            shed1.Color = "purple";
            Console.WriteLine(shed1);

        }
    }
}
