namespace _07.EncodeDecodeWithKey
{
    using System;
    using System.Text;

    class Program
    {
        // 07. Write a program that encodes and decodes a string using given encryption key (cipher).
        // The key consists of a sequence of characters. The encoding/decoding is done
        // by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
        // the second – with the second, etc. When the last key character is reached, the next is the first.

        static string Encrypt(string message, string key)
        {
            StringBuilder encryptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                int index = i % key.Length;
                char singleKeySybmol = key[index];
                char singleMessageSymbol = message[i];

                encryptedMessage.Append((char)(singleMessageSymbol ^ singleKeySybmol));
            }

            return encryptedMessage.ToString();
        }

        static string Decrypt(string message, string key)
        {
            return Encrypt(message, key);
        }

        static void Main()
        {
            string message = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";

            string key = "c# part 2";

            Console.WriteLine(message);
            Console.WriteLine();

            string encrypt = Encrypt(message, key);
            Console.WriteLine(encrypt);
            Console.WriteLine();

            string decrypt = Decrypt(encrypt, key);
            Console.WriteLine(decrypt);
        }
    }
}
