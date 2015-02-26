namespace _02.ReverseStringAndPrint
{
    using System;
    using System.Text;
    using System.Linq;

    class Program
    {
        // 2. Write a program that reads a string, reverses it and prints the result at the console.
        //    Example: "sample"  "elpmas".

        static void Main(string[] args)
        {
            Console.Write("Write something here: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            Console.WriteLine(sb);

            Console.WriteLine(input.Reverse().ToArray());
        }
    }
}
