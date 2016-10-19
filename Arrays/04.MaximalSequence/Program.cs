namespace _04.MaximalSequence
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the maximal sequence of equal elements in an array.
            // Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

            int[] numbers = { 2, 5, 5, 5, 5, 5, 1, 1, 2, 2, 2, 2, 2, 3, 3, 2, 2, 2, 6, 6, 6, 6, 6, 6, 1, 1, 1, 1 };

            int maxEqualSequence = 1;
            int tempEqualSequence = 1;

            string tempStringSequence = numbers[0].ToString();
            string maxStringSeqence = string.Empty;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    tempEqualSequence++;
                    tempStringSequence += ", " + numbers[i + 1].ToString();
                    if (maxEqualSequence < tempEqualSequence)
                    {
                        maxEqualSequence = tempEqualSequence;
                        maxStringSeqence = tempStringSequence;
                    }
                }
                else
                {
                    tempEqualSequence = 1;
                    tempStringSequence = numbers[i + 1].ToString();
                }
            }

            Console.WriteLine("The maximal sequence of equal elements in the array consist {0} elements", maxEqualSequence);
            Console.WriteLine(maxStringSeqence);
        }
    }
}
