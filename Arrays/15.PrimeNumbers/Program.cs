﻿namespace _15.PrimeNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds all prime numbers in the range [1...10 000 000].
            // Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


            bool[] numbers = new bool[10000001];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = true;
            }

            int max = (int)Math.Sqrt(numbers.Length);

            for (int i = 2; i <= max; i++)
            {
                if (numbers[i])
                {
                    for (int j = i * i; j < numbers.Length; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }

            Console.WriteLine("Press enter to see next number.");

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    Console.Write(i + " ");
                    Console.ReadLine();
                }
            }
        }
    }
}
