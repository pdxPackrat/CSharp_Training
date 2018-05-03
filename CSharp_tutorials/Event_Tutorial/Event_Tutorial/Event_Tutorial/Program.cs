using System;

namespace Event_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number(100000);

            myNumber.PrintMoney();
            myNumber.PrintNumber();
        }
    }
}
