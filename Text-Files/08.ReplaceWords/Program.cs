namespace _08.ReplaceWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        // 08. Modify the solution of the previous problem to replace only whole words (not substrings).

        static void Main(string[] args)
        {
            string fileLocation = "../../text.txt";
            string tempfile = "../../output.txt";

            using (StreamReader input = new StreamReader(fileLocation))
            {
                using (StreamWriter output = new StreamWriter(tempfile))
                {
                    string line; 
                    
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    }
                }
            }

            using (StreamReader input = new StreamReader(tempfile))
            {
                using (StreamWriter output = new StreamWriter(fileLocation))
                {
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine(line);
                    }
                }
            }
        }
    }
}
