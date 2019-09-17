/*
 * Logan Passi
 * 09/10/19
 * calcChange.cs
 * A simple program calculates the total amount of money from the number of inputted pennies and nickels.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class cCoin {

        private int Pennies = 0;
        private int Nickels = 0;
        private double ttl = 0.00;
        public void setPennies(int n) {
            Pennies = n;
        }

        public void setNickels(int n) {
            Nickels = n;
        }

        public double calc() {
            double pPer = (double)Pennies / 100.00;
            double nPer = (double)Nickels / 20.00;
            ttl = nPer + pPer;
            return ttl;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, p = 0;
            cCoin myCoins = new cCoin();

            Console.Write("Enter in the amount of pennies you have: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter in the amount of nickels you have: ");
            n = Convert.ToInt32(Console.ReadLine());

            myCoins.setNickels(n);
            myCoins.setPennies(p);

            Console.Write("Total amount of money: $" + myCoins.calc());

        }
    }
}

/*
Enter in the amount of pennies you have: 5
Enter in the amount of nickels you have: 2
Total amount of money: $0.15
*/