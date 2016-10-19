namespace _06.MaximalSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads two integer numbers N and K and an array of N elements from the console.
            // Find in the array those K elements that have maximal sum.

            int N = 0;
            int K = 0;

            while (true)
            {
                Console.Write("Insert integer N: ");
                N = int.Parse(Console.ReadLine());

                Console.Write("Insert integer K: ");
                K = int.Parse(Console.ReadLine());

                if (K > N)
                {
                    Console.WriteLine("K > N");
                }
                else
                {
                    break;
                }
            }

            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                int arrElement = 0;

                bool inputParsed = false;

                while (!inputParsed)
                {
                    Console.WriteLine("Insert arr[{0}]: ", i);

                    inputParsed = int.TryParse(Console.ReadLine(), out arrElement);

                    if (inputParsed == false)
                    {
                        Console.WriteLine("Incorect input!!! Try again!");
                    }
                }
                numbers[i] = arrElement;
            }

            Console.WriteLine(string.Join(", ", numbers));

            int maxSum = numbers[0];
            string maxSumToString = numbers[0].ToString();
            int combinations = (int)Math.Pow(2, N);

            for (int i = 0; i < combinations; i++)
            {

                int count = 0;
                int tempSum = 0;
                string tempSumtoString = "";

                for (int j = 0; j < N; j++)
                {
                    int mask = 1 << j;
                    int coincidence = i & mask;

                    if (coincidence != 0)
                    {
                        count++;
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

                    if (count > K)
                    {
                        break;
                    }
                    else if (maxSum < tempSum && count == K)
                    {
                        maxSum = tempSum;
                        maxSumToString = tempSumtoString;
                    }
                }
            }

            Console.WriteLine("Maximal sum = " + maxSum);
            Console.WriteLine("Subsum of: " + maxSumToString);

        }
    }
}
