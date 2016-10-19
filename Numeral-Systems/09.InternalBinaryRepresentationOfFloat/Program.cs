namespace _09.InternalBinaryRepresentationOfFloat
{
    using System;

    class Program
    {
        // * Write a program that shows the internal binary representation 
        // of given 32-bit signed floating-point number in IEEE 754 format 
        // (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

        // Base10ToBase2Integer(27) -> 11011
        static string Base10ToBase2Integer(int d)
        {
            string b = String.Empty;

            while (d != 0)
            {
                b = d % 2 + b;
                d /= 2;
            }
            //Console.WriteLine(b);
            return b;
        }

        // Base10ToBase2Fraction(.25) -> 01; 0.25 = 1 / 4 = 1 / (2 ^ 2) = 0.01 binary
        static string Base10ToBase2Fraction(float f)
        {
            string b = String.Empty;

            // 0.25 -> 0.5
            for (f *= 2; f != 0; f *= 2) // 0.5 -> 1 -> 0; 2 times
            {
                b += (int)f; // += 0; += 1;   b = 01
                f -= (int)f; // (int)0.5 = 0; 0.5 - 0 = 0.5; 1 - 1 = 0;
            }
            //Console.WriteLine(b);
            return b;
        }

        // Sign is 1 bit long
        static int GetSign(float f)
        {
            return f < 0 ? 1 : 0;
        }

        // Exponent is the next 8 bits
        static string GetExponent(string integer, string fraction)
        {
            // 1 -> 0; 2 -> 1; 3 -> 1; 4 -> 2; 5 -> 2; 6 -> 2; 7 -> 2; 8 -> 3; 9 -> 3; ... 15 -> 3; 16 -> 4 ...
            // 0.8 -> -1; 0.4 -> -2; 0.2 -> -3; 0.1 -> -4
            int exponent;

            // 1.23, 12.3, but not 0.12 or 0.00123

            if (integer.Length != 0) // 8 = 2 ^ 3 in binary is 1000 - power is +3 - positive
            {
                exponent = integer.Length - 1;
            }
            else // 0.125 = 1 / 8 in binary is 0.001 - power is -3 - negative
            {
                exponent = -fraction.IndexOf('1') - 1;
            }

            return Base10ToBase2Integer(127 + exponent).PadLeft(8, '0'); // Convert power to binary, 127 is the middle
        }

        // Mantissa is the last 23 bits
        static string GetMantissa(string integer, string fraction)
        {
            string mantissa;

            if (integer.Length != 0) // First is always 1 (if normalized)
            {
                // Console.WriteLine("substring " + integer.Substring(1));
                mantissa = integer.Substring(1) + fraction; // 1011 + 01
            } 
            else // No integer part - get first non-zero in fraction
            {
                mantissa = fraction.Substring(fraction.IndexOf('1') + 1); 
            }

            return mantissa.PadRight(23, '0'); // Left aligned
        }

        // TODO: 0, denormalized numbers, Infinity, NaN
        static void Main(string[] args)
        {

            float f = -27.25f; // 32 bits = 1 + 8 + 23 with 24 bits of precision in mantissa

            int sign = GetSign(f);

            if (sign == 1) // If the number is negative make it positive for easier calculations
            {
                f = -f;
            }

            string integer = Base10ToBase2Integer((int)f); // 27.25 -> 27 in binary string 11011
            string fraction = Base10ToBase2Fraction(f - (int)f); // 27.25 -> .25 in binary string 01

            Console.WriteLine("Sign: \t\t" + sign);
            Console.WriteLine("Exponent: \t" + GetExponent(integer, fraction));
            Console.WriteLine("Mantissa: \t" + GetMantissa(integer, fraction));
        }
    }
}
