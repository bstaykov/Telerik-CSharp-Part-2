namespace _00.Tests
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            try
            {
                //for (int i = 0; i < 134217728; i++)
                //{
                //    arr.Add(0); 
                //}

                while (true)
                {
                    arr.Add(0);
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(arr.Count);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
