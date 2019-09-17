/*
 * Logan Passi
 * 09/10/19
 * pow.cs
 * A short function using a pow method to raise a number to a power.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Math {
        public static int pow(int num, int exp) {

            int retValue = 1;
            for (int i = 0; i < exp; ++i) {
                retValue *= num;
            }

            return retValue;
        }
    }
    class pow
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.pow(num: 2, exp: 3));
        }
    }
}
