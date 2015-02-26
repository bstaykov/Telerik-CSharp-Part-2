namespace _02.ReadNumbers
{
    using System;

    class Program
    {
        // Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
        // If an invalid number or non-number text is entered, the method should throw an exception. 
        // Using this method write a program that enters 10 numbers:
        //	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        private static int ReadNumber(int start, int end)
        {
            try
            {
                Console.Write("Insert a number: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if (value < start || value > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return value;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input! Not a number!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid input! Out of range!!!");
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Invalid number! Number too big or too small!");
                Console.WriteLine(e.Message);
            }

            return ReadNumber(start, end);
        }

        private static int[] Enter10Numbers(int min, int max, int count)
        {
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    numbers[i] = ReadNumber(min, max);

                    if (i == 0)
                    {
                        if (numbers[i] == max)
                        {
                            Console.WriteLine("Imposible target!");
                            Console.WriteLine(string.Join(", ", numbers));
                            Console.WriteLine("Start again!");
                            numbers = new int[count];
                            i = 0;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if( i < count - 1 && numbers[i] == max)
                    {
                        Console.WriteLine("Imposible target!");
                        Console.WriteLine(string.Join(", ", numbers));
                        Console.WriteLine("Start again!");
                        numbers = new int[count];
                        i = 0;
                    }
                    else if (numbers[i - 1] < numbers[i])
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insert value > " + numbers[i]);
                    }
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(ReadNumber(100, 200));

            Console.WriteLine("Insert numbers a1, a2, … a10, such that 1 < a1 < … < a10 < 100");
            int[] numbers = Enter10Numbers(2, 99, 10);

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
