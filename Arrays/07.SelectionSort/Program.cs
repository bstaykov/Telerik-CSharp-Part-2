namespace _07.SelectionSort
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            // Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            // Use the "selection sort" algorithm: Find the smallest element, 
            // move it at the first position, find the smallest from the rest, move it at the second position, etc.

            int[] arr = { 3, 5, 1, 2, 12, 4, 10, 21, 12, 31, 41, 18, 28, 81 };

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if(arr[min] > arr[j+1])
                    {
                        min = j + 1;
                    }
                }

                //swap
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            Console.WriteLine(string.Join(", ", arr));
        }

    }
}
