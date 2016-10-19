namespace _02.CompareArrays
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads two arrays from the console and compares them element by element.

            Console.WriteLine("Insert length for the first array: ");
            int firstArrayLength = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstArrayLength];

            for (int i = 0; i < firstArrayLength; i++)
            {
                Console.Write("arrayOne[{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert length for the second array: ");
            int secondArrayLength = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondArrayLength];

            for (int i = 0; i < secondArrayLength; i++)
            {
                Console.Write("arrayTwo[{0}]: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array 1 : " + string.Join(", ", firstArray));
            Console.WriteLine("Array 2 : " + string.Join(", ", secondArray));

            int len = secondArrayLength;
            if (firstArrayLength < secondArrayLength)
            {
                len = firstArrayLength;
            }

            if (firstArrayLength != secondArrayLength)
            {
                Console.WriteLine("The arrays have different length!");
            }

            bool areArraysEqual = true;
            for (int i = 0; i < len; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areArraysEqual = false;
                    Console.WriteLine("Element at possition {0} are different.", i);
                    Console.WriteLine("{0} != {1}", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.WriteLine("Element at possition {0} are equal.", i);
                    Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
                }
            }

            if (areArraysEqual)
            {
                Console.WriteLine("Arrays are equal!");
            }
            else
            {
                Console.WriteLine("Arrays are not equal!");
            }
        }
    }
}
