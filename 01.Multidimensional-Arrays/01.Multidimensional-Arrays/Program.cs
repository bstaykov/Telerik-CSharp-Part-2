using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        // a)
        int[,] arr = new int[n, n];
        int counter = 0;

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = 1 + col * n + row;
            }
        }

        //for (int col = 0; col < arr.GetLength(1); col++)
        //{
        //    for (int row = 0; row < arr.GetLength(0); row++)
        //    {
        //        count++;
        //        arr[row, col] = count;
        //    }
        //}

        Console.WriteLine("\na)\n");

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // b)

        int[,] arr2 = new int[n, n];
        counter = 0;

        for (int col = 0; col < arr2.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < arr2.GetLength(0); row++)
                {
                    counter++;
                    arr2[row, col] = counter;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    counter++;
                    arr2[row, col] = counter;
                }
            }
        }

        Console.WriteLine("\nb)\n");

        for (int row = 0; row < arr2.GetLength(0); row++)
        {
            for (int col = 0; col < arr2.GetLength(1); col++)
            {
                Console.Write(arr2[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // c)

        counter = 1;
        int currentCol = 0;
        int currentRow = n - 1;
        int tempCol = 0;
        int tempRow = 0;
        string direction = "up";

        int[,] arr3 = new int[n, n];
        arr3[currentRow, currentCol] = counter;

        while (counter <= n * n)
        {
            counter++;
            if (direction == "up")
            {
                if (currentRow - 1 >= 0)
                {
                    currentRow--;
                }
                else if (currentCol + 1 < n)
                {
                    currentCol++;
                }

                arr3[currentRow, currentCol] = counter;
                tempRow = currentRow;
                tempCol = currentCol;
                direction = "diagonal";
            }
            else if (direction == "diagonal")
            {
                while (currentCol + 1 < n && currentRow + 1 < n)
                {
                    currentCol++;
                    currentRow++;
                    arr3[currentRow, currentCol] = counter;
                    if (currentCol + 1 < n && currentRow + 1 < n)
                    {
                        counter++;
                    }
                }
                direction = "up";
                currentRow = tempRow;
                currentCol = tempCol;
            }
        }

        Console.WriteLine("\nc)\n");

        for (int row = 0; row < arr3.GetLength(0); row++)
        {
            for (int col = 0; col < arr3.GetLength(1); col++)
            {
                Console.Write(arr3[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // d

        counter = 1;
        direction = "down";
        int[,] arr4 = new int[n, n];
        int maxRow = n - 1;
        int maxCol = n - 1;
        int minRow = 0;
        int minCol = 0;

        while (counter <= n * n)
        {

            for (int row = minRow; row <= maxRow; row++)
            {
                arr4[row, minCol] = counter;
                counter++;
            }
            minCol++;

            for (int col = minCol; col <= maxCol; col++)
            {
                arr4[maxRow, col] = counter;
                counter++;
            }
            maxRow--;

            for (int row = maxRow; row >= minRow; row--)
            {
                arr4[row, maxCol] = counter;
                counter++;
            }

            maxCol--;

            for (int col = maxCol; col >= minCol; col--)
            {
                arr4[minRow, col] = counter;
                counter++;
            }

            minRow++;
        }

        Console.WriteLine("\nd)\n");

        for (int row = 0; row < arr4.GetLength(0); row++)
        {
            for (int col = 0; col < arr4.GetLength(1); col++)
            {
                Console.Write(arr4[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
