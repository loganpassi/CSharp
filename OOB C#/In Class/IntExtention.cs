using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class IntExtentions
    {
        public static int Power(this int value, int exp)
        {
            if (exp == 0)
                return 1;

            else if (exp == 1)
                return value;
          
            else
                return value * value.Power(exp - 1);
        }
        public static int Add(this int value, int value2)
        {
            return value + value2;
        }
    }
    class IntExtention
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x.Add(10));
            Console.WriteLine(x.Power(3));
        }
    }
}
