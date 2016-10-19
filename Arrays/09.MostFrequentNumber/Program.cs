namespace _09.MostFrequentNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the most frequent number in an array. Example:
	        // {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

            int mostFreqNum = arr[0];
            int maxCount = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                int tempCount = 1;
                   
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    mostFreqNum = arr[i];
                }
            }
            Console.WriteLine("{0}({1} times)", mostFreqNum, maxCount);
        }
    }
}
