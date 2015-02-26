namespace _00.ParseInputToInt32Array
{
    using System;
    using System.Linq;

    public class InputParser
    {
        static void Main(string[] args)
        {
            char [] separators = new char [] {' ', ','};
            int[] numbers = Console.ReadLine()
                                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
