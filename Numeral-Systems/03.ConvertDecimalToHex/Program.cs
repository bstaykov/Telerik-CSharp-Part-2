namespace _03.ConvertDecimalToHex
{
    using System;
    using System.Text;

    class Program
    {
        // Write a program to convert decimal numbers to their hexadecimal representation.

        static char[] hexArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        static void Main(string[] args)
        {
            int decimalNumber = -256;
            string hexNumber = DecimalToHex(decimalNumber);
            Console.WriteLine(hexNumber);

            decimalNumber = 255;
            hexNumber = DecimalToHex(decimalNumber);
            Console.WriteLine(hexNumber);
        }

        private static string DecimalToHex(int decimalNumber)
        {
            bool isNegative = decimalNumber < 0 ? true : false;

            if (isNegative)
            {
                decimalNumber = -decimalNumber; //get the positive value

                //get the length of the bits in decimalNumber without left zeroes
                int length = Convert.ToString(decimalNumber, 2).Length;

                //we have to split the binary code by 4 bits
                int addition = 0;

                if (length % 4 != 0)
                {
                    //get the difference between length and 4 if it doesn't devide exactly
                    addition = 4 - length % 4;
                }

                int lengthBits = length + addition;

                //invert the bits till lengthbits with the XOR operator
                int mask = 1;
                for (int i = 0; i < lengthBits; i++)
                {
                    mask = 1 << i;
                    decimalNumber = decimalNumber ^ mask;
                }

                //we add + 1
                decimalNumber += 1;
            }

            StringBuilder sb = new StringBuilder();

            while (decimalNumber != 0)
            {
                //match the remaining with the coresponding element in the hex array
                sb.Append(hexArray[decimalNumber % 16]);
                decimalNumber /= 16;

            }

            string hex = sb.ToString();
            int lengthHex = hex.Length;
            sb.Clear();
            //reverse the array in the right way
            for (int i = lengthHex - 1; i >= 0; i--)
            {
                sb.Append(hex[i]);
            }

            if (isNegative)
            {
                hex = sb.ToString();
                sb.Clear();
                //fill the left spaces with F
                sb.Append(hex.PadLeft(8, 'F'));
            }

            return sb.ToString();
        }
    }
}
