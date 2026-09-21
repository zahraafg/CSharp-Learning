using System;

namespace MyFirstProgram
{
    internal class Program_11
    {
        public static void Run()
        {
            // YENI: Convert.ToInt32(a) AND (int)a

            double a = 3.5;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d);



            double a1 = 3.5;
            int b1 = (int)a1;
            Console.WriteLine(b1);

            int c1 = 123;
            double d1 = (double)c1 + 0.1;
            Console.WriteLine(d1);
        }
    }
}
