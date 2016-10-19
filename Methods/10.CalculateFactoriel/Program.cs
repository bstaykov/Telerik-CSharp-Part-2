namespace Methods10
{
    using System;
    using System.Text;
    using System.Numerics;

    class FactorielMethod
    {
        //Write a program to calculate n! for each n in the range[1..100]. Hint: Implement first a method
        //that multiplies a number represented as array of digits by given integer number.

        public static int[] NumberMultiplyer(int[] numbers, int number)
        {
            int [] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i] * number;
                int j = i;

                while (temp != 0)
                {
                    int left = temp % 10;
                    result[j] += left;
                    temp = temp / 10;
                    j++;
                }
            }

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > 9)
                {
                    int temp = result[i];
                    int left = temp % 10;
                    int over = temp / 10;

                    result[i] = left;
                    result[i + 1] += over;
                }
            }

            return result;
        }

        public static int [] CalculateFactoriel(int n)
        {
            if (n < 0)
            {
                throw new IndexOutOfRangeException("Negative is not allowed!");
            }

            int[] numbers = new int[n * n + 1];

            numbers[0] = 1;

            for (int i = 2; i <= n; i++) // i = 2 because !0 and !1 = 1
            {
                numbers = NumberMultiplyer(numbers, i);
            }

            return numbers;
        }

        public static BigInteger ConvertArray(int[] numbers)
        {
            int length = numbers.Length;
            StringBuilder sb = new StringBuilder(length * length + 1);

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sb.Append(numbers[i]);
            }

            BigInteger result = BigInteger.Parse(sb.ToString());

            return result;
        }

        public static void Main()
        {
            while (true)
            {

                Console.Write("n! for each n in the range [1..100] => ");
                int n = int.Parse(Console.ReadLine());

                int [] numbers = CalculateFactoriel(n);

                BigInteger finalResult = ConvertArray(numbers);

                Console.WriteLine("  My result: " + finalResult);
                
                // check 

                BigInteger factoriel = 1;

                int m = 1;

                while (m <= n)
                {
                    factoriel = factoriel * m;
                    m++;
                }

                Console.WriteLine("Big integer: {0}", factoriel);
            }
        }
    }
}

