namespace _14.QuickSort
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


            Console.Write("Unsorted elements: ");
            string[] unsortedStrings = { "a6", "a5", "e2", "d1", "b5", "4", "c7" };

            Console.WriteLine(string.Join(", ", unsortedStrings));

            Quicksort(unsortedStrings, 0, unsortedStrings.Length - 1);

            Console.WriteLine(string.Join(", ", unsortedStrings));
        }

        public static void Quicksort(string[] array, int left, int right)
        {
            int i = left, j = right;
            string middle = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(middle) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    string tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(array, left, j);
            }

            if (i < right)
            {
                Quicksort(array, i, right);
            }
        }
    }
}
