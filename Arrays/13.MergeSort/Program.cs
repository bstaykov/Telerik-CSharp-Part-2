namespace _13.MergeSort
{
    using System;

    class Program
    {
        // Write a program that sorts an array of integers using the Merge sort algorithm.

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 5, 1, 8, 6, 2, 32, 4, 10, 5, 11, 7, 9 };
            Console.WriteLine(string.Join(", ", numbers));
            int[] sortedArr = MergeSort(numbers);
            Console.WriteLine(string.Join(", ", sortedArr));
        }

        private static int[] MergeSort(int[] array)
        {
            var len = array.Length;

            if (len <= 1)
            {
                return array;
            }

            if (len == 2)
            {
                if (array[0] > array[1])
                {
                    int temp = array[0];
                    array[0] = array[1];
                    array[1] = temp;
                }
                return array;
            }

            int[] left = new int[len / 2];
            int[] right = new int[len - (len / 2)];
            Array.Copy(array, 0, left, 0, left.Length);
            Array.Copy(array, len / 2, right, 0, right.Length);

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeArrays(left, right);
        }

        private static int[] MergeArrays(int[] firstArr, int[] secondArr)
        {
            var len = firstArr.Length + secondArr.Length;

            int[] numbers = new int[len];

            for (int i = 0; i < len; i++)
            {
                if (firstArr != null && secondArr != null)
                {
                    if (firstArr[0] < secondArr[0])
                    {
                        numbers[i] = firstArr[0];

                        if (firstArr.Length > 1)
                        {
                            int[] newArr = new int[firstArr.Length - 1];
                            Array.Copy(firstArr, 1, newArr, 0, firstArr.Length - 1);

                            firstArr = newArr;
                        }
                        else
                        {
                            firstArr = null;
                        }

                    }
                    else
                    {
                        numbers[i] = secondArr[0];

                        if (secondArr.Length > 1)
                        {
                            int[] newArr = new int[secondArr.Length - 1];
                            Array.Copy(secondArr, 1, newArr, 0, secondArr.Length - 1);

                            secondArr = newArr;
                        }
                        else
                        {
                            secondArr = null;
                        }
                    }
                }
                else
                {
                    if (firstArr != null)
                    {
                        numbers[i] = firstArr[0];

                        if (firstArr.Length > 1)
                        {
                            int[] newArr = new int[firstArr.Length - 1];
                            Array.Copy(firstArr, 1, newArr, 0, firstArr.Length - 1);

                            firstArr = newArr;
                        }
                        else
                        {
                            firstArr = null;
                        }
                    }
                    else
                    {
                        numbers[i] = secondArr[0];

                        if (secondArr.Length > 1)
                        {
                            int[] newArr = new int[secondArr.Length - 1];
                            Array.Copy(secondArr, 1, newArr, 0, secondArr.Length - 1);

                            secondArr = newArr;
                        }
                        else
                        {
                            secondArr = null;
                        }
                    }
                }
            }

            return numbers;
        }

    }
}
