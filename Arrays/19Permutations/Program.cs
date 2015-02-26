namespace _19.Permutations
{
    using System;

    class Program
    {
        // Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = i + 1;
            }

            Perm(numbers, 0);
        }

        private static void Perm<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
                Print(arr);
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Swap<T>(ref T firstElement, ref T secondElement)
        {
            T temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

        private static void Print<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
