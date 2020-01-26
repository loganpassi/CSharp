using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class recAdd
    {
        static void Main(string[] args)
        {
            int num1 = 0; //variables to hold entered numbers from the user
            int num2 = 0;

            Console.Write("Please enter a positive integer: "); //prompt the user for input
            num1 = Int32.Parse(Console.ReadLine()); //get the input from the user

            Console.Write("Please enter another positive integer: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The sum of " + num1 + " plus " + num2 + " is: " + addRec(num1, num2)); //output the sum and call the addRec function

            int addRec(int a, int b) { //function to recursively add two positive integers
                
                if (b == 1 || a == 1) //if either integer is 1 then add then it is not necessary to recursively call
                {
                    return (a + b);
                }

                else {
                    a++;
                    return addRec(a, b - 1); //recursive call to calculate the sum
                }
            }

        }
    }
}
