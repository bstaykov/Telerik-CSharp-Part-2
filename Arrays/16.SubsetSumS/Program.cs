namespace _16.SubsetSumS
{
    using System;

    class Program
    {
        // We are given an array of integers and a number S. 
        // Write a program to find if there exists a subset of the elements of the array that has a sum S.

        // maybe they ment increasing subset?!

        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };

            int sum = 14;

            int combinations = (int)Math.Pow(2, numbers.Length);

            for (int i = 0; i < combinations; i++)
            {
                int tempSum = 0;
                string tempSumtoString = "";
                int lastAdded = int.MinValue;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = 1 << j;
                    int coincidence = i & mask;

                    if (coincidence != 0 && lastAdded < numbers[j])
                    {
                        tempSum += numbers[j];
                        lastAdded = numbers[j];
                        if (tempSumtoString.Equals(string.Empty))
                        {
                            tempSumtoString += numbers[j];
                        }
                        else
                        {
                            tempSumtoString += ", " + numbers[j];
                        }
                    }

                    if (tempSum > sum)
                    {
                        break;
                    }

                    if (tempSum == sum)
                    {
                        Console.WriteLine("Subset with elements = " + tempSumtoString);
                        return;
                    }
                }
            }

        }
    }
}
