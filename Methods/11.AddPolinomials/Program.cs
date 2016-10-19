namespace _11.AddPolinomials
{
    using System;

    class Program
    {
        // Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		// x2 + 5 = 1x2 + 0x + 5 

        static int[] AddPolinomials(int[] firstPolynoms, int[] secondPolynoms)
        {
            int length = firstPolynoms.Length;
            int commonLength = secondPolynoms.Length;
            bool firstIsLonger = firstPolynoms.Length > secondPolynoms.Length;

            if (!firstIsLonger)
            {
                length = secondPolynoms.Length;
                commonLength = firstPolynoms.Length;
            }

            int[] sumOfPolynoms = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (i < commonLength)
                {
                    sumOfPolynoms[i] = firstPolynoms[i] + secondPolynoms[i];
                }
                else if (firstIsLonger)
                {
                    sumOfPolynoms[i] = firstPolynoms[i];
                }
                else
                {
                    sumOfPolynoms[i] = secondPolynoms[i];
                }
            }

            return sumOfPolynoms;                       
        }

        static void PrintPolinomial(int[] polynoms)
        {
            bool isFirst = true;
            for (int i = polynoms.Length - 1; i >= 0; i--)
            {
                if (polynoms[i] > 0)
                {
                    if (isFirst == true)
                    {
                        Console.Write("{1}x^{0}", i, polynoms[i]);
                        isFirst = false;
                    }
                    else
                    {
                        Console.Write(" +{1}x^{0}", i, polynoms[i]);
                    }
                }
                else if(polynoms[i] < 0)
                {
                    Console.Write(" {1}x^{0}", i, polynoms[i]);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr1 = {0, 1, 5, -2, 0 , 0, -9};
            Console.WriteLine("Array 1: " + string.Join("\t", arr1));
            int[] arr2 = {0, -2, -4, 0, 0, 0, 1, 9};
            Console.WriteLine("Array 2: " + string.Join("\t", arr2));

            int[] sum = AddPolinomials(arr1, arr2);
            Console.WriteLine("Array 3: " + string.Join("\t", sum));

            PrintPolinomial(sum);
        }
    }
}
