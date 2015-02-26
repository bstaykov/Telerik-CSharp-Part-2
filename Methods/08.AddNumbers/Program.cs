namespace _08.AddNumbers
{
    using System;
    using System.Numerics;
    using System.Text;

    class Program
    {
        // Write a method that adds two positive integer numbers represented as arrays of digits 
        // (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
        // Each of the numbers that will be added could have up to 10 000 digits.

        static BigInteger AddArraysOfDigits(int[] arrayOne, int[] arrayTwo)
        {
            int arrayOneLength = arrayOne.Length;
            int arrayTwoLength = arrayTwo.Length;

            int length;
            int commonLength;
            bool firstIsLonger = arrayOneLength > arrayTwoLength;

            if (firstIsLonger)
            {
                length = arrayOneLength + 1;
                commonLength = arrayTwoLength;
            } 
            else 
            {
                length = arrayTwoLength + 1;
                commonLength = arrayOneLength;
            }

            int[] sum = new int[length];

            for (int i = 0; i < length - 1; i++)
            {
                if (i < commonLength)
                {
                    int number = arrayOne[i] + arrayTwo[i];

                    int numberToAdd = number % 10;

                    sum[i] += numberToAdd;

                    if (number >= 10)
                    {
                        sum[i + 1] += 1;
                    }
                }
                else if (firstIsLonger)
                {
                    sum[i] += arrayOne[i];
                    if (sum[i] >= 10)
                    {
                        sum[i] = sum[i] % 10;
                        sum[i + 1] += 1;
                    }
                }
                else
                {
                    sum[i] += arrayTwo[i];
                    if (sum[i] >= 10)
                    {
                        sum[i] = sum[i] % 10;
                        sum[i + 1] += 1;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                sb.Append(sum[i]);
            }

            BigInteger result = BigInteger.Parse(sb.ToString());

            return result;
        }

        static void Main(string[] args)
        {
            int[] firstArray = {  9, 1, 1, 9, 9, 9 };
            int[] secondArray = { 9, 9, 2, 3};
                                //8  1  4  2  0  0  1
                                //1002418

            BigInteger result = AddArraysOfDigits(firstArray, secondArray);
            Console.WriteLine(result);
        }
    }
}

// TODO