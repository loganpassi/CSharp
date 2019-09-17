using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int input = 0;

            for (int i = 0; i < 5; ++i) {
                Console.Write("Enter in a number: ");
                input = Convert.ToInt32(Console.ReadLine());
                result += input;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}
