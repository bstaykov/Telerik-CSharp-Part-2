using System;
using System.Collections.Generic;

class Program
{
    class LengthComparer : IComparer<string>
    {
        public int Compare(string firstString, string secondString)
        {
            var firstLength = firstString.Length;
            var secondLength = secondString.Length;
            return firstLength.CompareTo(secondLength);
        }
    }

    static void Main(string[] args)
    {
        // You are given an array of strings. Write a method that sorts the array by the length 
        // of its elements (the number of characters composing them).

        Console.Write("Insert N = ");
        int N = int.Parse(Console.ReadLine());

        string[] arrayOfStrings = new string[N];

        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            Console.Write("arr[" + i + "] = ");
            arrayOfStrings[i] = Console.ReadLine();
        }

        LengthComparer comparator = new LengthComparer();

        Array.Sort(arrayOfStrings, comparator);

        foreach (string value in arrayOfStrings)
        {
            Console.WriteLine(value);
        }
    }
}
