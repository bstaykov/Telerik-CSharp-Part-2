namespace _10.SequenceOfGivenSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds in given array of integers a sequence of given sum S (if present).
            // Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

            int[] numbers = {7, 4, 3, 1, -4, 4, 2, 5, 8, 3 };
            Console.Write("Sum = ");
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempSum = numbers[i];
                string tempSumSequence = numbers[i].ToString();

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    tempSum += numbers[j];
                    tempSumSequence += ", " + numbers[j].ToString();

                    if (tempSum == sum)
                    {
                        Console.WriteLine("Sequence: " + tempSumSequence);
                    }

                    //if we use only positive numbers 
                    //if (temp1 > sum)
                    //{
                    //    break;
                    //}

                }
            }
        }
    }
}
