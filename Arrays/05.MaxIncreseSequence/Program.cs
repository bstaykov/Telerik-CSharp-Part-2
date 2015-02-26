namespace _05.MaxIncreseSequence
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 3, 1, 2, 3, 4, 5, 7, 7, 8, 4, 3, 2, 4, 5, 1 };

            int maxIncreasingSequence = 1;
            int tempIncreasingSequence = 1;

            string tempStringSequence = arr[0].ToString();
            string maxStringSeqence = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    tempIncreasingSequence++;
                    tempStringSequence += " < " + arr[i + 1].ToString();
                    if (maxIncreasingSequence < tempIncreasingSequence)
                    {
                        maxIncreasingSequence = tempIncreasingSequence;
                        maxStringSeqence = tempStringSequence;
                    }
                }
                else
                {
                    tempIncreasingSequence = 1;
                    tempStringSequence = arr[i + 1].ToString();
                }
            }

            Console.WriteLine("The maximal increasing sequence in an the array consist {0} elements.", maxIncreasingSequence);
            Console.WriteLine(maxStringSeqence);
        }
    }
}
