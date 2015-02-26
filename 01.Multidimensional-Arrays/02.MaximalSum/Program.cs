using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
        // that has maximal sum of its elements.

        //initiate

        Console.Write("Insert N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Insert M = ");
        int M = int.Parse(Console.ReadLine());


        Console.Write("Insert size = ");
        int size = int.Parse(Console.ReadLine());

        int[,] arr = new int[N, M];

        // read

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.WriteLine("arr[{0},{1}] = ", row, col);
                arr[row, col] = int.Parse(Console.ReadLine());
            }
        }

        // write

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //sum

        string squareStartPossition = "arr[0,0]";
        int maxSum = int.MinValue;

        for (int row = 0; row < arr.GetLength(0) - (size - 1); row++)
        {
            for (int col = 0; col < arr.GetLength(1) - (size - 1); col++)
            {
                int tempSum = 0;
                for (int r = row; r < (row + size); r++)
                {
                    for (int c = col; c < (col + size); c++)
                    {
                        tempSum += arr[r, c];
                    }
                }

                //tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2]
                //    + arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2]
                //    + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    squareStartPossition = "arr[" + row + "," + col + "]";
                }
            }
        }

        Console.WriteLine("Start possition: " + squareStartPossition);
        Console.WriteLine("Maximal sum = " + maxSum);
    }
}