/*
 * Logan Passi
 * 09/10/19
 * recursionFactorial.cs
 * Short program to use recursion to find the factorial of a number.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class recursionFactorial
    {

        static int fact(int n) {
            if (n == 0)
            {
                return 1;
            }
            else {
                return n * fact(n - 1);
            }

            
        }
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Please enter a value to find the factorial of: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + "! = " + fact(num));
        }
    }
}

/*
Please enter a value to find the factorial of: 5
5! = 120
Press any key to continue . . .
*/