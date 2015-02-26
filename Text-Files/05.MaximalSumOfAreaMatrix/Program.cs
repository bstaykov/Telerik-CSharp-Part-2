using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalSumOfAreaMatrix
{
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

        private static void MaximalSum(int[,] arr)
        {

            string squareStartPossition = "arr[0,0]";
            int maxSum = int.MinValue;
            int tempSum = maxSum;

            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    tempSum = arr[row, col] + arr[row, col + 1] + arr[row + 1, col] + arr[row + 1, col + 1];
            
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        squareStartPossition = "arr[" + row + "," + col + "]";
                    }
                }
            }

            Console.WriteLine("Start possition: " + squareStartPossition);
            Console.WriteLine("Maximal sum = " + maxSum);

            StreamWriter writer = new StreamWriter(@"..\..\answer.txt", false);
            writer.WriteLine(maxSum);

            writer.Flush();
            writer.Close();
        }

        private static int[,] ReadArrFromFile(string fileLocation)
        {
            StreamReader reader = new StreamReader(fileLocation);
            string line = reader.ReadLine();
            int rowlAndCol = int.Parse(line);
            int rows = rowlAndCol;
            int cols = rowlAndCol;

            int [,] arr = new int[rows, cols];
            int[] colArr = new int[cols];
            int rowTo = 0;

            line = reader.ReadLine();
            
            while (line != null)
            {
                colArr = StringToIntArr(line);
                for (int i = 0; i < cols; i++)
                {
                    arr[rowTo, i] = colArr[i];
                }
                rowTo++;
                line = reader.ReadLine();
            }

            reader.Close();

            return arr;
        }

        private static int[] StringToIntArr(string line)
        {
            char[] separator = { ' ' };
            string[] arr2 = line.Split(separator);
            int [] arr = new int[arr2.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arr2[i]);
            }

            return arr;
        }

        static void Main(string[] args)
        {
            string fileLocation = @"..\..\file1.txt";

            int[,] arr1 = {
                            { 2, 3, 3, 4 },
                            { 0, 2, 3, 4 },
                            { 3, 7, 1, 2 },
                            { 4, 3, 3, 2 } 
                          };

            int[,] arr2 = ReadArrFromFile(fileLocation);
            MaximalSum(arr2);
            //check
            MaximalSum(arr1);

            //for (int row = 0; row < arr.GetLength(0); row++)
            //{
            //    for (int col = 0; col < arr.GetLength(1); col++)
            //    {
            //        Console.Write(arr[row, col] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
        }
    }
}
