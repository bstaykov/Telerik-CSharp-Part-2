namespace _03.ReturnLastDigit
{

    using System;
    class Program
    {
        // Write a method that returns the last digit of given integer as an English word. 
        // Examples: 512  "two", 1024  "four", 12309  "nine".

        static string ReturnLastDigit(int number)
        {
            int lastDigit = number % 10;

            if (lastDigit < 0)
            {
                lastDigit = -lastDigit;
            }

            string result = "";

            switch (lastDigit)
            {
                case 1: result = "One";
                    break;
                case 2: result = "Two";
                    break;
                case 3: result = "Three";
                    break;
                case 4: result = "Four";
                    break;
                case 5: result = "Five";
                    break;
                case 6: result = "Six";
                    break;
                case 7: result = "Seven";
                    break;
                case 8: result = "Eight";
                    break;
                case 9: result = "Nine";
                    break;
                case 0: result = "Zero";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Is this possible!");
            }

            return result;
        }

        static void Main(string[] args)
        {
            string lastdigit = ReturnLastDigit(123);
            Console.WriteLine(lastdigit);

            lastdigit = ReturnLastDigit(-2226);
            Console.WriteLine(lastdigit);

            lastdigit = ReturnLastDigit(0);
            Console.WriteLine(lastdigit);
        }
    }
}
