namespace _02.GetMax
{
    using System;

    class Program
    {
        // Write a method GetMax() with two parameters that returns the bigger of two integers. 
        // Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

        static int GetMax(int firstNumber, int secondNumber)
        {
            int max = firstNumber;
            if (secondNumber > firstNumber)
            {
                max = secondNumber;
            }
            return max;
        }

        static int FindBiggestOfThreeNumbers()
        {
            Console.WriteLine("Insert integer A: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert integer B: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert integer C: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);

            max = GetMax(max, thirdNumber);

            return max;
        }

        static void Main(string[] args)
        {
            int max = FindBiggestOfThreeNumbers();
            Console.WriteLine("Max = {0}", max);
        }
    }
}
