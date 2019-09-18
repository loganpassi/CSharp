using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            for (int i = 0; i < x.Length; ++i)
            {
                x[i] = i;
            }

            foreach (int z in x)
            {
                Console.WriteLine(z);
            }

            List<int> list1 = new List<int>();
            for (int i = 0; i < 10; ++i)
            {
                list1.Add(i);
            }

            foreach (int z in list1)
            {
                Console.WriteLine(z);
            }

            ArrayList arrayList1 = new ArrayList();
            for (int i = 0; i < 10; ++i)
            {
                arrayList1.Add(i);
            }

            foreach (int z in arrayList1) {
                Console.WriteLine(z);
            }

            int w = (int)arrayList1[0];
        }
    }
}
