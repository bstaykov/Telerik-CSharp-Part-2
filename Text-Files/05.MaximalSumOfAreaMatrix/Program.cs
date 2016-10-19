namespace _05.MaximalSumOfAreaMatrix
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        // Write a program that reads a text file containing a square matrix of numbers 
        // and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
        // The first line in the input file contains the size of matrix N. 
        // Each of the next N lines contain N numbers separated by space. 
        // The output should be a single number in a separate text file. Example:
        //4
        //2 3 3 4
        //0 2 3 4			17
        //3 7 1 2
        //4 3 3 2

        private static void WriteMaximalSumOfSubMatrix(string destinationFile, int[,] matrix, int sizeOfSquare = 2)
        {
            if (matrix.GetLength(0) < sizeOfSquare)
            {
                throw new ArgumentOutOfRangeException("Size is more than matrix size.");
            }

            string squareStartPossition = "matrix[0,0]";
            int maxSum = int.MinValue;
            int tempSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - sizeOfSquare + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - sizeOfSquare + 1; col++)
                {
                    tempSum = SumOfSubMatrix(matrix, row, col, sizeOfSquare);

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        squareStartPossition = "matrix[" + row + "," + col + "]";
                    }
                }
            }

            //Console.WriteLine("Start possition: " + squareStartPossition);
            //Console.WriteLine("Square's size = " + sizeOfSquare);
            //Console.WriteLine("Maximal sum = " + maxSum);

            using (StreamWriter writer = new StreamWriter(destinationFile, false))
            {
                writer.WriteLine(maxSum);
            }
        }

        private static int SumOfSubMatrix(int[,] matrix, int startRow, int startCol, int sizeOfSubMatrix)
        {
            int sum = 0;

            for (int i = startRow; i < startRow + sizeOfSubMatrix; i++)
            {
                for (int j = startCol; j < startCol + sizeOfSubMatrix; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            string fileLocation = @"..\..\file1.txt";
            string destinationFile = @"..\..\answer.txt";
            int sizeOfSubMatrix = 2;
            int[,] matrix = ReadMatrixFromFile(fileLocation);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            WriteMaximalSumOfSubMatrix(destinationFile, matrix, sizeOfSubMatrix);

            Console.WriteLine("Check file!");

        }

        private static int[] ParseToNumbers(string numbersAsString)
        {
            var numbers = numbersAsString
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            return numbers;
        }

        private static int[,] ReadMatrixFromFile(string fileDirectory)
        {
            using (StreamReader streamReader = new StreamReader(fileDirectory))
            {
                string sizeAsString = streamReader.ReadLine();

                int sizeOfMatrix;

                bool isSizeCorrect = int.TryParse(sizeAsString, out sizeOfMatrix);

                if (isSizeCorrect == false)
                {
                    throw new InvalidCastException("Invalid input on file.");
                }

                int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

                for (int i = 0; i < sizeOfMatrix; i++)
                {
                    string line = streamReader.ReadLine();

                    if (line != null)
                    {
                        int[] rowNumbers = ParseToNumbers(line);

                        for (int j = 0; j < sizeOfMatrix; j++)
                        {
                            matrix[i, j] = rowNumbers[j];
                        }
                    }
                    else
                    {
                        throw new IOException("Invalid line count.");
                    }
                }

                return matrix;
            }
        }
    }
}
