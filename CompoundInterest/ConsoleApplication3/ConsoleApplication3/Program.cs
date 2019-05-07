using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    int amount, cent; //amount on deposit at end of year           
                    int principal = 1000; //initial amount       before interest           
                    double rate = 0.05; //interest rate
                    Console.WriteLine("Year{0,20}", "Amount on deposit");
                    for (int year = 1; year <= 10; ++year)
                    {
                        amount =(int)((principal * (Math.Pow(1.0 + rate, year))) * 100);
                        cent = amount % 100;
                        amount /= 100;
                        //display amount               
                        Console.WriteLine("{0,4}{1,20}.{2}", year, amount, cent);
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
