namespace _18.RemoveElements
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        /*  Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the 
         *  remaining array is sorted in increasing order. 
         *  Print the remaining sorted array.*/

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 1, 2, 6, 1, 8, 3, 9, 11, 20, 15, 22, 21 };
            List<int> indices = new List<int>();
            int len = numbers.Count;
            int combinations = (int)Math.Pow(2, len);

            for (int i = 0; i < combinations; i++)
            {
                List<int> tempIndices = new List<int>();
                bool isFirstFromSequence = true;
                int lastNumber = 0;

                for (int j = 0; j < len; j++)
                {
                    int mask = 1 << j;
                    int coincidence = i & mask;

                    if (coincidence != 0)
                    {
                        if (isFirstFromSequence)
                        {
                            isFirstFromSequence = false;
                            tempIndices.Add(j);
                            lastNumber = numbers[j];
                        }
                        else if(lastNumber < numbers[j])
                        {
                            tempIndices.Add(j);
                            lastNumber = numbers[j];
                        }
                        else
                        {
                            if (tempIndices.Count > indices.Count)
                            {
                                indices = tempIndices;
                            }
                            break;
                        }
                    }
                }
            }
            
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!(indices.Contains(i)))
                {
                    numbers.RemoveAt(i);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                } 
                Console.Write(numbers[i]) ;
            }

        }
    }
}
