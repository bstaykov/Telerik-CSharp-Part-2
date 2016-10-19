namespace _02.ConvertBinaryToDecimal
{
    using System;

    class Program
    {
        // 02. Write a program to convert binary numbers to their decimal representation.

        static string ReadDecimalInput()
        {
            string input = string.Empty;
            bool isCorrect = false;
            while (!isCorrect)
            {
                isCorrect = true;
                Console.Write("Insert binary number: ");
                input = Console.ReadLine();
                if (input != string.Empty && input.Length <= 32)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != '0' && input[i] != '1')
                        {
                            input = string.Empty;
                            Console.WriteLine("Incorect input! Only '1' amd '0' allowed!");
                            isCorrect = false;
                            break;
                        }
                    }
                }
                else if (input == string.Empty)
                {
                    Console.WriteLine("Empty input!");
                    isCorrect = false;
                }
                else
                {
                    Console.WriteLine("Incorect input! No more that 32 digits!");
                    isCorrect = false;
                }
            }

            return input;
        }

        static int BinaryToDecimal(string input)
        {
            int resultNumber = 0;

            if (input.Length == 32 && input[0] == '1') // negative
            {
                int power = input.Length - 2;
                int singleNumber = 0;
                
                for (int i = 1; i < input.Length; i++, power--) // start from input[1] because input[0] holds the sign
                {
                    singleNumber = int.Parse(input[i].ToString());
                    if (singleNumber == 0)
                    {
                        resultNumber += (int)Math.Pow(2, power);
                    }
                }
                resultNumber = -resultNumber - 1;

            }
            else // positive
            {
                int power = input.Length - 1;
                int singleNumber = 0;

                for (int i = 0; i < input.Length; i++, power--)
                {
                    singleNumber = int.Parse(input[i].ToString());
                    if (singleNumber == 1)
                    {
                        resultNumber += (int)Math.Pow(2, power);
                    }
                }
            }

            return resultNumber;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string input = ReadDecimalInput();

                int parsedToDecimal = BinaryToDecimal(input);
                Console.WriteLine(parsedToDecimal);

                // check
                int n = Convert.ToInt32(input, 2);
                Console.WriteLine(n);
            }
        }
    }
}
//for (int i = 0; i < input.Length; i++)
//{
//    decNum = decNum << 1;
//    if (input[i] == '1')
//    {
//        decNum = decNum ^ 1;
//    }
//}