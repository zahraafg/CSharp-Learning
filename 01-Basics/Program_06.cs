using System;

namespace MyFirstProgram
{
    internal class Program_06
    {
        public static void Run()
        {
            // double convert to int
            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }
    }
}
