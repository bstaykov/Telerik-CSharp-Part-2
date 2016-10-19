namespace _01.CalculateSquareRoot
{
    using System;

    class Program
    {
        // Write a program that reads an integer number and calculates and prints its square root.
        // If the number is invalid or negative, print "Invalid number".
        // In all cases finally print "Good bye". Use try-catch-finally.

        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number! FormatException");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Invalid number! OverflowException");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number! Negative number!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
