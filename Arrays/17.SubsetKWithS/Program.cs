namespace _17.SubsetKWithS
{
    using System;

    /*Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
        Find in the array a subset of K elements that have sum S or indicate about its absence.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("S = ");
            int sum = int.Parse(Console.ReadLine());
            bool isSubset = false;

            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("N[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int combinations = (int)Math.Pow(2, numbers.Length);

            for (int i = 0; i < combinations; i++)
            {
                int tempSum = 0;
                string tempSumtoString = "";
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = 1 << j;
                    int coincidence = i & mask;

                    if (coincidence != 0)
                    {
                        counter++;
                        tempSum += numbers[j];
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
                }

                if (tempSum == sum && counter == K)
                {
                    Console.WriteLine("Subset with elements = " + tempSumtoString);
                    isSubset = true;
                }
            }

            if (isSubset == false)
            {
                Console.WriteLine("No such subset");
            }
        }
    }
}
