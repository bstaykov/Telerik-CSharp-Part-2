namespace _07.LargestArea
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        // Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.


        public static HashSet<Possition> uncheckedPossitions = new HashSet<Possition>();
        public static int size = 5;
        public static int[,] arrayOfDigits;
        public static int largestAreaCount = 0;
        public static string largestAreaDigit = string.Empty;
        public static int tempAreaCount = 0;
        public static string tempAreaDigit = string.Empty;
        
        public static bool[,] visitedElemets = new bool[size, size];

        static void Main(string[] args)
        {
            arrayOfDigits = GenerateMatrixOfDigits(size, size);

            PrintMatrix(arrayOfDigits);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (visitedElemets[row, col] == false)
                    {
                        tempAreaDigit = arrayOfDigits[row, col].ToString();
                        AddUncheckedPossitionRecursive(row, col);
                        
                        if (tempAreaCount > largestAreaCount)
                        {
                            largestAreaCount = tempAreaCount;
                            largestAreaDigit = tempAreaDigit;
                        }

                        Console.WriteLine("Temp area count = " + tempAreaCount);
                        Console.WriteLine("Temp area digit = " + tempAreaDigit);

                        foreach (var item in uncheckedPossitions)
                        {
                            Console.WriteLine("[{0}, {1}]", item.row, item.col);
                        }
                        Console.WriteLine();
                        uncheckedPossitions.Clear();

                        tempAreaCount = 0;
                        tempAreaDigit = string.Empty;
                    }
                }
            }

            Console.WriteLine("Largest area count = " + largestAreaCount);
            Console.WriteLine("Largest area digit = " + largestAreaDigit);
        }

        private static int[,] GenerateMatrixOfDigits(int width, int height)
        {
            int[,] arrayOfDigits = new int[width, height];

            Random ran = new Random();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arrayOfDigits[i, j] = ran.Next(0, 3);
                }
            }

            return arrayOfDigits;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine(); 
                Console.WriteLine();
            }

        }

        private static void AddUncheckedPossitionRecursive(int row, int col)
        {
            bool isInsideMatrix = row >= 0 && row < size && col >= 0 && col < size;

            if (isInsideMatrix == false)
            {
                return;
            }

            bool isChecked = visitedElemets[row, col];
            if (!isChecked)
            {
                if (tempAreaDigit == arrayOfDigits[row, col].ToString())
                {
                    tempAreaCount++;
                }
                else
                {
                    return;
                }

                visitedElemets[row, col] = true;

                var possition = new Possition(row, col);
                uncheckedPossitions.Add(possition);

                AddUncheckedPossitionRecursive(row, col - 1);
                AddUncheckedPossitionRecursive(row, col + 1);
                AddUncheckedPossitionRecursive(row - 1, col);
                AddUncheckedPossitionRecursive(row + 1, col);
            }
        }
    }

    public class Possition
    {
        public int row;
        public int col;

        public Possition(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public override int GetHashCode()
        {
            int result = this.row << 7 + this.col << 17;
            return result;
        }
    }
}
