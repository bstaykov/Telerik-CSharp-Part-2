namespace _04.CountNumber
{
    using System;

    class Program
    {
        // Write a method that counts how many times given number appears in given array. 
        // Write a test program to check if the method is working correctly.

        static int CountNumber(int[] numbers, int number)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 6, 23, 4, 2, 3, 1, 1, 2, 3, 4, 3, 2, 1, 4, 4, 3 };

            Console.WriteLine("Method result");

            int numberToBeCounted = 4;

            int numberApearances = CountNumber(numbers, numberToBeCounted);

            Console.WriteLine("{0} appears {1} times.", numberToBeCounted, numberApearances);

            // test
            Console.WriteLine("Test result");
            string number = numberToBeCounted.ToString();

            string arrayToString = string.Join(":", numbers);
            int stringCounter = 0;

            while(true)
            {
                int index = arrayToString.IndexOf(number.ToString());
                if (index != -1)
                {
                    stringCounter++;
                    arrayToString = arrayToString.Substring(index + 1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("{0} appears {1} times.", number, stringCounter);
        }
    }
}
