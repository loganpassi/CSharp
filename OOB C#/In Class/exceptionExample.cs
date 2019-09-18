using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionExample
{
    class MyException : Exception {

        public MyException(string msg) : base(msg) {

        }
    }
    class exceptionExample
    {
        static void Main(string[] args)
        {
            //throw new Exception("This is my exception!");
            try
            {
                throw new MyException("This is my custom exception");
            } catch (Exception e)
            {
                Console.WriteLine("Programe did not crash");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
