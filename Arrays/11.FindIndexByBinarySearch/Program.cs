namespace _11.FindIndexByBinarySearch
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the index of given element in a sorted array of integers
            // by using the binary search algorithm (find it in Wikipedia).

            int[] numbers = { -2, -1, 0, 1, 3, 5, 8, 11, 22, 44, 55, 112, 2344 };
                         //0 , 1, 2, 3, 4, 5, 6,  7,  8,  9, 10,  11, 12
            Console.WriteLine("Array: " + string.Join(", ", numbers));

            int minIndex = 0;
            int maxIndex = numbers.Length;
            int middleIndex = numbers.Length / 2;
            bool exist = true;

            Console.Write("Number to be found: ");
            int number = int.Parse(Console.ReadLine());

            while (numbers[middleIndex] != number)
            {
                if (minIndex == maxIndex)
                {
                    Console.WriteLine("The array doesn't contain that integer!");
                    exist = false;
                    break;
                }

                if (numbers[middleIndex] > number)
                {
                    maxIndex = middleIndex - 1;
                }
                else
                {
                    minIndex = middleIndex + 1;
                }

                middleIndex = (minIndex + maxIndex) / 2;

            }

            if (exist == true)
            {
                Console.WriteLine("Index : {0}", middleIndex);
            }
        }
    }
}
