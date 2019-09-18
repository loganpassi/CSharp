using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class disposeTest : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException("Cleaning up disposable test");
        }
    }

    class destructTest {
        ~destructTest() {

            Console.WriteLine("Cleaning up destruct test");
        }
    }
    class garbageCollectorHack
    {

        static void A() {

            destructTest test = new destructTest();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("top");
            /*{
                //destructTest test = new destructTest();

                using (disposeTest test = new disposeTest()) ;
            }*/

            for (int i = 0; i < 300; ++i) {
                A();
            }

            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("bottom");


        }
    }
}
