namespace _05.IsBiggerThanNeighbors
{
    using System;

    class Program
    {
        // Write a method that checks if the element at given position in given array of integers
        // is bigger than its two neighbors (when such exist).

        static void IsBiggerThanNeighbors(int possition, params int [] arr)
        {
            if (possition > 0 && possition < arr.Length - 1)
            {
                if (arr[possition - 1] < arr[possition] && arr[possition] > arr[possition + 1])
                {
                    Console.WriteLine("Element in position {0} is bigger than its two neighbors.", possition);
                }
                else
                {
                    Console.WriteLine("Element in position {0} is not bigger than its two neighbors.", possition);
                }
            }
            else if(possition == 0 || possition == arr.Length - 1)
            {
                Console.WriteLine("Only one neighbor exists!");
            }
            else
            {
                Console.WriteLine("Incorrect position!");
            }
        }

        static void Main(string[] args)
        {
            int possition = 2;

            int[] arr = { 1, 3, 7, 6 };

            IsBiggerThanNeighbors(possition, arr);

            IsBiggerThanNeighbors(possition, 1, 3, 7, 6);
        }
    }
}
