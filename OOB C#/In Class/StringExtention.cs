using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class StringExtentionMethods
    {

        public static string UppercaseFirstLetter(this string value)
        {
            return char.ToUpper(value[0]) + String.Join("", value.Skip(1));
        }
    }
    class StringExtention
    {
        static void Main(string[] args)
        {
            string test = "hello";
            Console.WriteLine(test.UppercaseFirstLetter());
        }
    }
}
