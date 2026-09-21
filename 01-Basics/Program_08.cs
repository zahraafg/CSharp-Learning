using System;

namespace MyFirstProgram
{
    internal class Program_08
    {
        public static void Run()
        {
            // string convert to char
            String a = "Z";
            char b = Convert.ToChar(a);

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }
    }
}
