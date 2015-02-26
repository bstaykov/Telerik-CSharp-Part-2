namespace _15.WorkWithAnyType
{
    using System;

    // * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
    //   Use generic method (read in Internet about generic methods in C#).

    public class Program
    {
        private static void CalculateProduct<T>(T [] numbers)
        {
            dynamic product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product = product * numbers[i];
            }

            Console.WriteLine("Product = " + product);
        }

        private static void CalculateSum<T>(T[] numbers)
        {
            dynamic sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("Sum = " + sum);
        }

        private static void CalculateAverage<T>(T[] numbers)
        {
            dynamic sum = 0;
            dynamic average;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            average = sum / numbers.Length;
            Console.WriteLine("Average = " + average);
        }

        private static void FindMax<T>(T[] numbers)
        {
            dynamic MAX = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (MAX < numbers[i])
                {
                    MAX = numbers[i];
                }
            }

            Console.WriteLine("Maximum = " + MAX);
        }

        private static void FindMin<T>(T[] numbers)
        {
            dynamic MIN = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (MIN > numbers[i])
                {
                    MIN = numbers[i];
                }
            }

            Console.WriteLine("Minimum = " + MIN);
        }

        static void Main()
        {
            int[] numbers1 = new int[5] { 1, 4, 6, 1, 8 }; 
            Console.WriteLine("int..");
            FindMin(numbers1);
            FindMax(numbers1);
            CalculateProduct(numbers1);
            CalculateSum(numbers1);
            CalculateAverage(numbers1);
            Console.WriteLine();

            byte[] numbers2 = new byte[5] { 1, 4, 6, 1, 8 };
            Console.WriteLine("byte..");
            FindMin(numbers2);
            FindMax(numbers2);
            CalculateProduct(numbers2);
            CalculateSum(numbers2);
            CalculateAverage(numbers2);
            Console.WriteLine();

            double[] numbers3 = new double[5] { 1.01, 4.02, 6.03, 1.04, 8.05 };
            Console.WriteLine("double..");
            FindMin(numbers3);
            FindMax(numbers3);
            CalculateProduct(numbers3);
            CalculateSum(numbers3);
            CalculateAverage(numbers3);
            Console.WriteLine();
        }
    }
}
