using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float e = 1F, index = 1F, den = 1F;
            const int SIZE = 1000;
            while(index < SIZE + 1)
            {
                for(float i = 1F; i < index + 1F; i++)
                {
                    den *= i;
                }
                e += 1 / den;
                den = 1F;
                index++;
            }
            Console.WriteLine("e = " + e);
        }
    }
}
