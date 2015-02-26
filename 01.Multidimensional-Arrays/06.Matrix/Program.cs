namespace _06.Matrix
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Matrix firstMatrix = new Matrix(new int[,]{{1, 2, 3, 4}, {5, 6, 7, 8}});
            Console.WriteLine("First matrix");
            Console.WriteLine(firstMatrix);

            Matrix secondMatrix = new Matrix(new int[,] { { 3, 2, 1, 0 }, { 5, 6, 7, 8 } });
            Console.WriteLine("Second matrix");
            Console.WriteLine(secondMatrix);

            Matrix thirdMatrix = new Matrix(new int[,] { { 1, 2, 1, 2 }, { 2, 1, 2, 1 } });
            Console.WriteLine("Third matrix");
            Console.WriteLine(thirdMatrix);

            Matrix forthMatrix = new Matrix(new int[,] { { 1, 2 }, { 2, 1 }, { 1, 2 }, { 2, 1 } });
            Console.WriteLine("Forth matrix");
            Console.WriteLine(forthMatrix);

            Matrix sumOfMatrix = firstMatrix + secondMatrix;
            Console.WriteLine("Add first & second");
            Console.WriteLine(sumOfMatrix.ToString());

            Matrix substractionOfMatrix = firstMatrix - thirdMatrix;
            Console.WriteLine("Substact first & third");
            Console.WriteLine(substractionOfMatrix.ToString());

            Matrix productOfMatrix = firstMatrix * forthMatrix;
            Console.WriteLine("Product first & forth");
            Console.WriteLine(productOfMatrix.ToString());

            Console.WriteLine("[0,0] = " + productOfMatrix[0, 0]);
            Console.WriteLine("[1,1] = " + productOfMatrix[1, 1]);
            Console.WriteLine("[2,2] = " + productOfMatrix[2, 2]);
            Console.WriteLine("[3,3] = " + productOfMatrix[3, 3]);
        }
    }
}
