using System;

namespace MyFirstProgram
{
    internal class Program_03
    {
        public static void Run()
        {
            int x; // declaration 
            x = 123; // initialization
             
            int y = 321; // declaration + initialization

            int z = x + y;

            Console.WriteLine(x); 
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
