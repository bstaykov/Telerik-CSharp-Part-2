namespace _06.ReturnIndex
{
    using System;

    class Program
    {
        // Write a method that returns the index of the first element in array that is bigger than its neighbors, 
        // or -1, if there’s no such element. Use the method from the previous exercise.

        static int IsBiggerThanNeighbors(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return -1;
            }
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 2, 4, 6, 7, 5, 8, 9, 10, 15, 1, 3, 7, 6 };

            int result = IsBiggerThanNeighbors(numbers);
            Console.WriteLine("Index => {0}", result);
        }
    }
}
