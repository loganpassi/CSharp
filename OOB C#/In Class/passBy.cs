/*
 * Logan Passi
 * 09/10/19
 * passBy.cs
 * A simple program that shows the differences between pass by value, pass by reference, and pass by value reference
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PassTest {

        public int value = 5;

    }
    class passBy
    {
        static void f1(int x) {
            x = 4;
        }

        static void f2(ref int x) {
            x = 7;
        }

        static void f3(PassTest t) {
            t.value = 10;
        }

        static void f4(ref PassTest t) {
            t = new PassTest();
            t.value = 20;
        }
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine(x);

            f1(x);
            Console.WriteLine(x);

            f2(ref x);
            Console.WriteLine(x);

            PassTest t = new PassTest();
            Console.WriteLine(t.value);
            f3(t);
            Console.WriteLine(t.value);

            f4(ref t);
            Console.WriteLine(t.value);
        }
    }
}
