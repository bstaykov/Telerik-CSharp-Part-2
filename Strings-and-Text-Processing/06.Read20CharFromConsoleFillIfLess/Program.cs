namespace _06.Read20CharFromConsoleFillIfLess
{
    using System;

    class Program
    {
        // 6. Write a program that reads from the console a string of maximum 20 characters. 
        // If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
        // Print the result string into the console.
 
        static void Main(string[] args)
        {
            Console.WriteLine("Insert something here:");
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                input = input.Substring(0, 20);
            }
            else
            {
                input = input.PadRight(20, '*');
            }

            Console.WriteLine(input);

            Console.WriteLine("Do it again:");
            Console.WriteLine(Console.ReadLine().Substring(0, 20).PadRight(20, '*'));

        }
    }
}
