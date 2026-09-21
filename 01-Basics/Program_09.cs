using System;

namespace MyFirstProgram
{
    internal class Program_09
    {
        public static void Run()
        {
            // string convert to bool
            String a = "true";
            bool b = Convert.ToBoolean(a);

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }
    }
}
