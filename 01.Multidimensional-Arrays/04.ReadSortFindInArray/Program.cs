using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program, that reads from the console an array of N integers and an integer K,
        // sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        Console.Write("Insert N = ");
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("arr[" + i + "] = ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine("int [] = {0}", string.Join(", ", numbers));

        while (true)
        {
            Console.Write("Insert K = ");
            int K = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(numbers, K);

            if (index >= 0)
            {
                Console.WriteLine("Value K found on possition " + index);
            }
            else
            {
                if (K > numbers[numbers.Length - 1])
                {
                    Console.WriteLine("Max value <= K is " + numbers[numbers.Length - 1]);
                }
                else if (K < numbers[0])
                {
                    Console.WriteLine("All values are bigger than K!");
                }
                else
                {
                    int leftIndex = 0;
                    int rightIndex = numbers.Length - 1;
                    int middleIndex = (leftIndex + rightIndex) / 2;

                    while (true)
                    {
                        if (leftIndex > rightIndex)
                        {
                            Console.WriteLine("The array doesn't contain that integer!");

                            if (numbers[leftIndex] < K)
                            {
                                Console.WriteLine("Element closest and smaller than K is " + numbers[leftIndex]);
                            }
                            else
                            {
                                Console.WriteLine("Element closest and smaller than K is " + numbers[leftIndex - 1]);
                            }
                            break;
                        }

                        if (numbers[middleIndex] > K)
                        {
                            rightIndex = middleIndex - 1;
                        }
                        else
                        {
                            leftIndex = middleIndex + 1;
                        }

                        middleIndex = (leftIndex + rightIndex) / 2;
                    }
                }
            }
        }
    }
}
