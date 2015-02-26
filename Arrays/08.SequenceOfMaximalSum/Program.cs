namespace _08.SequenceOfMaximalSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the sequence of maximal sum in given array. Example:
	        // {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	        // Can you do it with only one loop (with single scan through the elements of the array)?

            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int maxSum = numbers[0];
            string maxSumToString = numbers[0].ToString();

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempSum = numbers[i];
                string tempSumToString = numbers[i].ToString();


                for (int j = i + 1; j < numbers.Length; j++)
                {
                    tempSum += numbers[j];
                    tempSumToString += ", " +numbers[j].ToString();

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxSumToString = tempSumToString;
                    }

                }
            }

            Console.WriteLine(maxSum);
            Console.WriteLine(maxSumToString);
        }
    }
}
