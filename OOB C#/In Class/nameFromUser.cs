using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class nameFromUser
    {
        static void Main(string[] args)
        {
            String name = "";

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello, {0}, Big Brother is watching!", name);
        }
    }
}

/*
Please enter your name: Logan
Hello, Logan, Big Brother is watching!
Press any key to continue . . .
*/