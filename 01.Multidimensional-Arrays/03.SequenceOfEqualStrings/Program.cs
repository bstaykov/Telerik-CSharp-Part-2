using System;

class Program
{
    static void Main(string[] args)
    {
        // We are given a matrix of strings of size N x M. 
        // Sequences in the matrix we define as sets of several neighbor elements located on the same line, 
        // column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:

        //initiate

        Console.Write("Insert N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Insert M = ");
        int M = int.Parse(Console.ReadLine());

        string[,] arr = new string[N, M];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.WriteLine("arr[{0},{1}] = ", row, col);
                arr[row, col] = Console.ReadLine();
            }
        }

        //read

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // check

        string longestSequence = "";
        int longestSequenceCount = 0;
        int rowIndex = 0;
        int colIndex = 0;

        string tempSequence = "";
        int tempCount = 0;

        string direction = "No such sequence!";

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                // row

                tempCount = 1;
                tempSequence = arr[row, col];
                for (int i = row; i < arr.GetLength(0) - 1; i++)
                {
                    if (arr[row, col].Equals(arr[i + 1, col]))
                    {
                        tempSequence += ", " + arr[i + 1, col];
                        tempCount += 1;

                        if (tempCount > longestSequenceCount)
                        {
                            longestSequence = tempSequence;
                            longestSequenceCount = tempCount;
                            direction = "vertical";
                            rowIndex = row;
                            colIndex = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                //col

                tempCount = 1;
                tempSequence = arr[row, col];
                for (int i = col; i < arr.GetLength(1) - 1; i++)
                {
                    if (arr[row, col].Equals(arr[row, i + 1]))
                    {
                        tempSequence += ", " + arr[row, i + 1];
                        tempCount += 1;

                        if (tempCount > longestSequenceCount)
                        {
                            longestSequence = tempSequence;
                            longestSequenceCount = tempCount;
                            direction = "horizontal";
                            rowIndex = row;
                            colIndex = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                // diagonal

                tempCount = 1;
                tempSequence = arr[row, col];
                for (int i = col, j = row; i < arr.GetLength(1) - 1 && j < arr.GetLength(0) - 1; i++, j++)
                {
                    if (arr[row, col].Equals(arr[j + 1, i + 1]))
                    {
                        tempSequence += ", " + arr[j + 1, i + 1];
                        tempCount += 1;

                        if (tempCount > longestSequenceCount)
                        {
                            longestSequence = tempSequence;
                            longestSequenceCount = tempCount;
                            direction = "diagonal";
                            rowIndex = row;
                            colIndex = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Longest sequence [" + longestSequenceCount + "] is: " + longestSequence);
        Console.WriteLine("Direction => " + direction);
        Console.WriteLine("Start position [{0}, {1}]", rowIndex, colIndex);
    }
}

