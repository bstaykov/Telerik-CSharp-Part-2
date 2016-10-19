namespace _02.RandomValues
{
    using System;

    class Program
    {
        // 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].
        
        private static void RandomValuesIncluding(int start, int end)
        {
            Random random = new Random();
            int value;

            for (int i = 0; i < 10; i++)
            {
                //value = random.Next(end - start + 1) + start;
                value = random.Next(start, end + 1);
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            RandomValuesIncluding(100, 200);
            Console.WriteLine();
            RandomValuesIncluding(2, 4);
        }
    }
}
