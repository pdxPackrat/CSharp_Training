using System;

namespace Delegate_Exercise
{
    class Program
    {
        public delegate void MyDel(string text1); // the lesson here is that delegates can hold MULTIPLE function pointers

        static public event MyDel myEvent; // using an event so that I can 

        static void Main(string[] args)
        {
            myEvent = Method1;
            myEvent += Method2;
            myEvent += Method3;

            string myString = "testing 1 2 3";
            myEvent(myString);
        }

        static void Method1 (string str1)
        {
            Console.WriteLine($"Entering method1:  value is {str1}");
        }

        static void Method2 (string str2)
        {
            Console.WriteLine($"Entering method2:  value is {str2}");
        }

        static void Method3 (string str3)
        {
            Console.WriteLine($"Entering method3:  value is {str3}");
        }
        
    }
}
