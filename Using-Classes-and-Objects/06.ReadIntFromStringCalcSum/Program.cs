namespace _06.ReadIntFromStringCalcSum
{
    using System;

    class Program
    {
        // You are given a sequence of positive integer values written into a string, separated by spaces. 
        // Write a function that reads these values from given string and calculates their sum. Example:
		// string = "43 68 9 23 318"  result = 461

        private static string[] ReadIntFromString(string input)
        {
            string[] arrayOfStrings = input.Split( new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return arrayOfStrings;
        }

        private static int[] ParseStringArrToIntArr(string [] array)
        {
            int[] numbers = new int[array.Length];

            for (int i  = 0; i  < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            return numbers;
        }

        private static long CalculateSum(int[] numbers)
        {
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindSum("43  68 9  23 318"));
        }

        static long FindSum(string input)
        {
            string[] values = ReadIntFromString(input);

            int[] numbers = ParseStringArrToIntArr(values);

            return CalculateSum(numbers);
        }
    }
}
