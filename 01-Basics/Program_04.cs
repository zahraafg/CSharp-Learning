using System;

namespace MyFirstProgram
{
    internal class Program_04
    {
        public static void Run()
        {
            int age = 24;
            double height = 46.80;
            bool alive = true;
            char symbol = '@';
            string name = "Zahra";

            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your height is: " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);
            Console.WriteLine("Hello " + name);

            string userName = symbol + name;

            Console.WriteLine("Your userName is: " + userName);

            Console.ReadKey();
        }
    }
}
