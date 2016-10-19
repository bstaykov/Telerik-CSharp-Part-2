namespace _01.UserName
{

    using System;
    class Program
    {
        // Write a method that asks the user for his name and prints “Hello, <name>” 
        // (for example, “Hello, Peter!”). Write a program to test this method.

        static void PrintHello()
        {
            Console.WriteLine("What is your name?");
            Console.Write("My name is ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, my name is Pesho Goshov.", name);
        }

        static void Main(string[] args)
        {
            PrintHello();
        }
    }
}
