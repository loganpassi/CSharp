/*
 * Logan Passi
 * 01/27/2020
 * arrAvg.cs
 * Short Program that will calculate the average value from values in an array and then calculate
 * which values are larger than that average.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class arrAvg
    {
        static void Main(string[] args)
        {
            int count = 0; //holds the number of values that is larger than the average
            int sum = 0; //holds the sum of all elements in the array
            int avg = 0; //holds the average value of the elements
            int listLen = 0; //holds the length of the array
            Console.Write("Please enter in the length of the list: "); //Get input from the user to determine how large they want the array to be
            listLen = Int32.Parse(Console.ReadLine());

            while (listLen > 100) { //Check to see if the entered value is not larger than 100
                Console.Write("Please enter a value that is not larger than 100: ");
                listLen = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int[] numArr = new int[listLen]; //Create the array based on the user input

            for (int i = 0; i < listLen; ++i) { //Iterate through the array to get input for each element
                Console.Write("Please enter in a value for element " + (i + 1) + ": ");
                numArr[i] = Int32.Parse(Console.ReadLine());
                sum += numArr[i]; //sum the up numbers while we are getting the input
            }

            avg = sum / listLen; //Calculate the average

            for (int i = 0; i < listLen; ++i) { //Iterate through the list again to find what values are larger than the avg
                if (numArr[i] > avg) {
                    count++;
                }
            }

            Console.WriteLine("\nThe average value is: " + avg); //Output the average and then the number of values larger than the average
            Console.WriteLine("The number of values that is larger than the average is: " + count);



        }
    }
}

/*
Please enter in the length of the list: 5000
Please enter a value that is not larger than 100: 10

Please enter in a value for element 1: 1
Please enter in a value for element 2: 2
Please enter in a value for element 3: 5
Please enter in a value for element 4: 3
Please enter in a value for element 5: 4
Please enter in a value for element 6: 6
Please enter in a value for element 7: 7
Please enter in a value for element 8: 8
Please enter in a value for element 9: 9
Please enter in a value for element 10: 10

The average value is: 5
The number of values that is larger than the average is: 5
Press any key to continue . . .
*/