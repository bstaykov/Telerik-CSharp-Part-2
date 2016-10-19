namespace _12.SumMultPolinoms
{
    using System;

    class Program
    {
        // Extend the program to support also subtraction and multiplication of polynomials.

        static int[] SubstractPolynoms(int[] firstPolynoms, int[] secondPolynoms)
        {
            int length = firstPolynoms.Length;
            int commonLength = secondPolynoms.Length;
            bool firstIsLonger = firstPolynoms.Length > secondPolynoms.Length;

            if (!firstIsLonger)
            {
                length = secondPolynoms.Length;
                commonLength = firstPolynoms.Length;
            }

            int[] substractOfPolynoms = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (i < commonLength)
                {
                    substractOfPolynoms[i] = firstPolynoms[i] - secondPolynoms[i];
                }
                else if (firstIsLonger)
                {
                    substractOfPolynoms[i] = firstPolynoms[i];
                }
                else
                {
                    substractOfPolynoms[i] = -secondPolynoms[i];
                }
            }

            return substractOfPolynoms;
        }

        static int[] MultiplyPlolynoms(int[] firstPolynoms, int[] secondPolynoms)
        {

            int length = firstPolynoms.Length + secondPolynoms.Length;

            int[] results = new int[length];

            for (int i = 0; i < firstPolynoms.Length; i++)
            {
                for (int j = 0; j < secondPolynoms.Length; j++)
                {
                    if (firstPolynoms[i] != 0 && secondPolynoms[j] != 0)
                    {
                        results[i + j] += firstPolynoms[i] * secondPolynoms[j];
                    }
                }
            }

            return results;
        }

        static void PrintPolynomial(int[] polinomial)
        {
            bool begining = false;
            for (int i = polinomial.Length - 1; i >= 0; i--)
            {
                if (polinomial[i] > 0)
                {
                    if (begining == false)
                    {
                        Console.Write("{1}x^{0}", i, polinomial[i]);
                        begining = true;
                    }
                    else
                    {
                        Console.Write(" +{1}x^{0}", i, polinomial[i]);
                    }
                }
                else if (polinomial[i] < 0)
                {
                    Console.Write(" {1}x^{0}", i, polinomial[i]);
                    if (begining == false)
                    {
                        begining = true;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] firstPolynom = { 0, 2, -3, 0 };
            Console.WriteLine("Array 1: " + string.Join("\t", firstPolynom));
            int[] secondPolynom = { 0, 4, 0, 2 };
            Console.WriteLine("Array 2: " + string.Join("\t", secondPolynom));
            Console.WriteLine();

            // substract 
            Console.WriteLine("Substracting...\n");

            int[] substract = SubstractPolynoms(firstPolynom, secondPolynom);
            Console.WriteLine("Array 3: " + string.Join("\t", substract));
            PrintPolynomial(substract);

            int[] substract2 = SubstractPolynoms(secondPolynom, firstPolynom);
            Console.WriteLine("Array 4: " + string.Join("\t", substract2));
            PrintPolynomial(substract2);

            // multiply 
            Console.WriteLine("Multiply...\n");
            int[] multiply = MultiplyPlolynoms(firstPolynom, secondPolynom);
            Console.WriteLine("Array 5: " + string.Join("\t", multiply));
            PrintPolynomial(multiply);

        }
    }
}
