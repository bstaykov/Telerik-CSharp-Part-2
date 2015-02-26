namespace _05.HexToBinary
{
    using System;

    class Program
    {
        // Write a program to convert hexadecimal numbers to binary numbers (directly).

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter a Hexadecimal number");
                Console.WriteLine("USE ONLY 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, a, b, c, d, e, f ");
                string myNumber = Console.ReadLine().ToUpper();
                Console.WriteLine("Number in Binary:");
                Console.WriteLine(HexToBinaryDirect(myNumber));

                //Console.WriteLine(HexToBinary(myNumber));
            }
        }
        //public static string HexToBinary(string myNumber)
        //{
        //    string result = string.Empty;
        //    int tempNumber = 0;      // we take a temporary Number where we will save each Hex number and convert
        //    for (int i = 0; i < myNumber.Length; i++)     // into 4 digits binary number before
        //    {                                             // parsing it to the final result
        //        if (System.Char.IsLetter(myNumber[i]))
        //        {
        //            switch (myNumber[i])
        //            {
        //                case 'A': result = result + "1010";
        //                    break;
        //                case 'B': result = result + "1011";           // we check for letters
        //                    break;
        //                case 'C': result = result + "1100";
        //                    break;
        //                case 'D': result = result + "1101";
        //                    break;
        //                case 'E': result = result + "1110";
        //                    break;
        //                case 'F': result = result + "1111";
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            tempNumber = int.Parse(myNumber[i].ToString());    // we take the value of the first number
        //            string tempResult = "";
        //            int remainder = 0;
        //            while (tempNumber > 0)
        //            {
        //                tempResult = (tempNumber % 2) + tempResult;  // converting it to decimal
        //                tempNumber /= 2;
        //            }
        //            remainder = tempResult.Length % 4;
        //            if (remainder != 0)                 // here we check the digits of the number
        //            {                                   // if they are not 4 we add '0', remainder times
        //                result = result + new string('0', 4 - remainder) + tempResult;
        //            }
        //            else                                // if they are 4 we simply add the 4 digit binary to the final string
        //            {
        //                result = result + tempResult;
        //            }
        //        }
        //    }

        //    return result;
        //}

        private static string HexToBinaryDirect(string hexNumber){

            string result = string.Empty;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                result = result + SymbolToBinary(hexNumber[i]);
            }

            return result;
        }

        private static string SymbolToBinary(char symbol)
        {
            switch (symbol.ToString().ToUpper())
            {
                case "0":
                    return "0000";
                case "1":
                    return "0001";
                case "2":
                    return "0010";
                case "3":
                    return "0011";
                case "4":
                    return "0100";
                case "5":
                    return "0101";
                case "6":
                    return "0110";
                case "7":
                    return "0111";
                case "8":
                    return "1000";
                case "9":
                    return "1001";
                case "A":
                    return "1010";
                case "B":
                    return "1011";
                case "C":
                    return "1100";
                case "D":
                    return "1101";
                case "E":
                    return "1110";
                case "F":
                    return "1111";
                default:
                    throw new ArgumentOutOfRangeException("Invalid symbol!");
            }
        }
    }
}
