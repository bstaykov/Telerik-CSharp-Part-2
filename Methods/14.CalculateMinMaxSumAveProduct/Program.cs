namespace _14.CalculateMinMaxSumAveProduct
{
    using System;
    using System.Numerics;

    class Program
    {
        // Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        // Use variable number of arguments.
        
        private static void CalculateProduct(double[] numbers)
        {
            BigInteger product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product = product * (BigInteger)numbers[i];
            }

            Console.WriteLine("Product = " + product);
        }

        private static void CalculateSum(double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("Sum = " + sum);
        }

        private static void CalculateAverage(double[] numbers)
        {
            double sum = 0;
            double average;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            average = sum / numbers.Length;
            Console.WriteLine("Average = " + average);
        }

        private static void FindMax(double[] numbers)
        {
            double MAX = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (MAX < numbers[i])
                {
                    MAX = numbers[i];
                }
            }

            Console.WriteLine("Maximum = " + MAX);
        }

        private static void FindMin(double[] numbers)
        {
            double MIN = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (MIN > numbers[i])
                {
                    MIN = numbers[i];
                }
            }

            Console.WriteLine("Minimum = " + MIN);
        }

        private static double[] InitiateArray()
        {
            bool isNumber = false;
            int length = 0;

            while (!isNumber)
            {
                Console.Write("Array length = ");
                string input = Console.ReadLine();

                bool canParse = int.TryParse(input, out length);

                if (canParse && length > 0)
                {
                    isNumber = true;
                }
                else if (canParse && length <= 0)
                {
                    Console.WriteLine("Incorect N! N must be > 0!");
                }
                else
                {
                    Console.WriteLine("Incorect input!");
                }
            }

            double[] numbers = new double[length];

            for (int i = 0; i < length; i++)
            {
                isNumber = false;
                while (!isNumber)
                {
                    Console.Write("Insert N[{0}] = ", i);
                    string input = Console.ReadLine();
                    double n = 0;

                    bool canParse = double.TryParse(input, out n);

                    if (canParse)
                    {
                        numbers[i] = n;
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorect input!");
                    }
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            double[] arr = InitiateArray();

            FindMin(arr);
            Console.WriteLine();

            FindMax(arr);
            Console.WriteLine();

            CalculateAverage(arr);
            Console.WriteLine();

            CalculateSum(arr);
            Console.WriteLine();

            CalculateProduct(arr);
        }
    }
}
