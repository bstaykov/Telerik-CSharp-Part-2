namespace _06.Matrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        public Matrix(int size)
        {
            this.Content = new int[size, size];
            this.Width = size;
            this.Height = size;
        }

        public Matrix(int width, int height)
        {
            this.Content = new int[width, height];
            this.Width = width;
            this.Height = height;
        }

        public Matrix(int[,] array)
        {
            this.Content = array;
            this.Width = array.GetLength(0);
            this.Height = array.GetLength(1);
        }

        public int[,] Content { get; set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            bool isWidthEqual = firstMatrix.Width == secondMatrix.Width;
            bool isHightEqual = firstMatrix.Height == secondMatrix.Height;
            if (isWidthEqual && isHightEqual)
            {
                Matrix sumMatrix = new Matrix(firstMatrix.Width, firstMatrix.Height);
                for (int i = 0; i < firstMatrix.Width; i++)
                {
                    for (int j = 0; j < firstMatrix.Height; j++)
                    {
                        sumMatrix.Content[i, j] = firstMatrix.Content[i, j] + secondMatrix.Content[i, j];
                    }
                }

                return sumMatrix;
            }
            else
            {
                throw new InvalidOperationException("Matrixs have different size!");
            }
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            bool isWidthEqual = firstMatrix.Width == secondMatrix.Width;
            bool isHightEqual = firstMatrix.Height == secondMatrix.Height;
            if (isWidthEqual && isHightEqual)
            {
                Matrix sumMatrix = new Matrix(firstMatrix.Width, firstMatrix.Height);
                for (int i = 0; i < firstMatrix.Width; i++)
                {
                    for (int j = 0; j < firstMatrix.Height; j++)
                    {
                        sumMatrix.Content[i, j] = firstMatrix.Content[i, j] - secondMatrix.Content[i, j];
                    }
                }

                return sumMatrix;
            }
            else
            {
                throw new InvalidOperationException("Matrixs have different size!");
            }
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            bool isWidthEqualToHeight = firstMatrix.Width == secondMatrix.Height;
            bool isHightEqualToWidth = firstMatrix.Height == secondMatrix.Width;
            if (isWidthEqualToHeight && isHightEqualToWidth)
            {
                Matrix productMatrix = new Matrix(firstMatrix.Height, secondMatrix.Width);

                for (int row = 0; row < productMatrix.Width; row++)
                {
                    for (int col = 0; col < productMatrix.Height; col++)
                    {
                        for (int inner = 0; inner < firstMatrix.Width; inner++)
                        {
                            productMatrix.Content[col, row] += firstMatrix.Content[inner, col] * secondMatrix.Content[row, inner];
                        }
                    }
                }

                return productMatrix;
            }
            else
            {
                throw new InvalidOperationException("Invalid operation!");
            }
        }

        public int this[int row, int col]
        {
            get
            {
                return this.Content[row, col];
            }
            set
            {
                this.Content[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.Width * this.Height * 2);

            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    sb.Append(this.Content[i, j] + "\t");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
