using System;

namespace MyFirstProgram
{
    internal class Program_10
    {
        public static void Run()
        {
            // QEYD: Convert.ToInt32(a) AND (int)a

            double a = 3.5;
            int b = Convert.ToInt32(a); // Convert.ToInt32(a) → ən yaxın tam ədədə yuvarlaqlaşdırır(round).

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());



            double a1 = 3.5;
            int b1 = (int)a; // (int)a → kəsir hissəni atır (truncate).

            Console.WriteLine(a1);
            Console.WriteLine(a1.GetType());

            Console.WriteLine(b1);
            Console.WriteLine(b1.GetType());



            int a2 = 123;
            double b2 = (double)a2 + 0.1;

            Console.WriteLine(a2);
            Console.WriteLine(a2.GetType());

            Console.WriteLine(b2);
            Console.WriteLine(b2.GetType());

            Console.ReadKey();
        }
    }
}
