using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventExample
{
    class MyEvent
    {
        public delegate void IntChanged(int originalValue, int newValue);
        public event IntChanged IntEvent;

        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                if (IntEvent != null)
                {
                    IntEvent(number, value);
                }
                number = value;
            }
        }
    }

    class eventExample
    {
        static void Main(string[] args)
        {
            MyEvent event1 = new MyEvent();
            event1.IntEvent += Event1_IntEvent;
            event1.Number = 20;
            event1.Number = 50;
            event1.Number = 999;
        }

        private static void Event1_IntEvent(int originalValue, int newValue)
        {
            Console.WriteLine($"original value = {originalValue} - new value = {newValue}");
        }
    }
}
