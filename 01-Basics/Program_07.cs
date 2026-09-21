using System;

namespace MyFirstProgram
{
    internal class Program_07
    {
        public static void Run()
        {
            // int convert to double
            int a = 123;
            double b = Convert.ToDouble(a) + 0.1;

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }
    }
}
