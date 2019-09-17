using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class numFromUser
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Please enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);

        }
    }
}

/*
Please enter an integer: 4
Please enter another integer: 5
4 + 5 = 9
4 * 5 = 20
Press any key to continue . . .
*/