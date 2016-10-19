using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComplexRevercingCalculatingPlus
{
    class Program
    {
        // Write a program that can solve these tasks:
        // Reverses the digits of a number 
        // Calculates the average of a sequence of integers
        // Solves a linear equation a * x + b = 0
        // Create appropriate methods.
        // Provide a simple text-based menu for the user to choose which task to solve.
        // Validate the input data:
        // The decimal number should be non-negative
        // The sequence should not be empty
        // a should not be equal to 0


        static void menu()
        {
            bool hasTask = true;
            while (hasTask)
            {
                Console.WriteLine();
                Console.WriteLine("1. Reverse the digits of a number");
                Console.WriteLine("2. Calculates the average of a sequence of integers");
                Console.WriteLine("3. Solve a linear equation a * x + b = 0");
                Console.WriteLine("0. EXIT");
                Console.WriteLine("Choose now or never speak of this again!!!\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ReverseDecimal();
                        break;
                    case "2":
                        CalculateAverage();
                        break;
                    case "3":
                        SolveEquation();
                        break;
                    case "0":
                        hasTask = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Try again!");
                        break;
                }

            }
        }

        private static void SolveEquation()
        {
            double a;
            double b;

            while (true)
            {
                Console.Write("A = ");
                string input = Console.ReadLine();

                bool canParse = double.TryParse(input, out a);

                if (canParse && a != 0)
                {
                    break;
                }
                else if (canParse && a == 0)
                {
                    Console.WriteLine("Insert A != 0");
                }
                else
                {
                    Console.WriteLine("Incorect input! Try again!");
                }


            }
            while (true)
            {
                Console.Write("B = ");
                string input = Console.ReadLine();

                bool canParse = double.TryParse(input, out b);

                if (canParse)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorect input! Try again!");
                }
            }
            Console.WriteLine("a*x + b = 0");
            Console.WriteLine("{0}*x + {1} = 0", a, b);
            Console.WriteLine("x = " + -b / a);
        }

        private static void ReverseDecimal()
        {
            while (true)
            {
                Console.Write("Insert positive decimal number: ");

                string input = Console.ReadLine();
                decimal N;

                bool canParse = decimal.TryParse(input, out N);

                if (canParse && N >= 0)
                {
                    string reversed = string.Empty;

                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        reversed += input[i];
                    }

                    N = decimal.Parse(reversed);
                    Console.WriteLine("Reversed number is: " + N);
                    return;
                }
                else if (canParse && N < 0)
                {
                    Console.WriteLine("Invalid input! Number not positive!");
                }
                else
                {
                    Console.WriteLine("Invalid input!!!");
                }
            }
        }

        private static void CalculateAverage()
        {
            while (true)
            {
                Console.Write("Insert N: ");
                string input = Console.ReadLine();

                int N;
                double sum = 0;

                bool canParse = int.TryParse(input, out N);

                if (canParse && N > 0)
                {
                    int counter = 0;
                    while (counter < N)
                    {
                        Console.Write("Insert N[{0}] = ", counter);
                        string number = Console.ReadLine();
                        double parsedNumber;

                        bool parseSeq = double.TryParse(number, out parsedNumber);
                        if (parseSeq)
                        {
                            sum += parsedNumber;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid N[{0}]!!!", counter);
                        }

                    }
                    Console.WriteLine("The sum of the sequense is: {0}", sum);
                    Console.WriteLine("Average = " + sum / N);
                    return;
                }
                else if (canParse && N < 0)
                {
                    Console.WriteLine("Invalid N!!! Try again N > 0");
                }
                else
                {
                    Console.WriteLine("Invalid N!!! Try again!");
                }
            }
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}
