namespace _09.MaxElement
{
    using System;

    class Program
    {
        // Write a method that return the maximal element in a portion of array of integers starting at given index.
        // Using it write another method that sorts an array in ascending / descending order.

        static int FindMax(int startIndex = 0, params int[] numbers)
        {
            int maxIndex = startIndex;

            for (int i = startIndex + 1; i < numbers.Length; i++)
            {
                if (numbers[maxIndex] < numbers[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static void SortArray(int[] numbers, bool sortAsc = true)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int maxIndex = FindMax(i, numbers);

                int temp = numbers[maxIndex];
                numbers[maxIndex] = numbers[i];
                numbers[i] = temp;
            }

            if (sortAsc)
            {
                Array.Reverse(numbers);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 8, 9, -11, 2, 4, 6, -22 };
            Console.WriteLine(string.Join(", ", numbers));

            // find max element starting at given index

            int index = 6;
            Console.WriteLine("The maximal element, starting from index {0}, is : {1}", index, numbers[FindMax(index, numbers)]);

            SortArray(numbers);
            Console.WriteLine("Sorted ASC: " + string.Join(", ", numbers));
            SortArray(numbers, false);
            Console.WriteLine("Sorted DESC: " + string.Join(", ", numbers));
        }
    }
}
