using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Tutorial
{
    class PrintHelper
    {
        // declare delegate
        public delegate void BeforePrint(string message);

        // declare event of type delegate
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {
            
        }

        public void PrintNumber(int num)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }


        public void PrintDecimal(int dec)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("PrintDecimal");

            Console.WriteLine("Number: {0:G}", dec);
        }


        public void PrintMoney(int money)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("PrintMoney");

            Console.WriteLine("Number: {0:C}", money);
        }


        public void PrintTemperature(int num)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemperature");

            Console.WriteLine("Number: {0,4:N1} F", num);
        }


        public void PrintHexidecimal(int dec)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("PrintHexidecimal");

            Console.WriteLine("Number: {0:X}", dec);
        }
    }
}
