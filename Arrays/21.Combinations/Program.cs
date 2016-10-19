using System;

//Write a program that reads two numbers N and K and generates all the combinations of K
//distinct elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


public static class CombinationsWithoutRepetition
{
    public static int N;
    public static int K;
    public static int[] numbersArray = new int[20];
    public static void Print(uint length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0:D} ", numbersArray[i]);
        }
        Console.Write("\n");
    }
    public static void Komb(uint i, uint after)
    {
        uint j;
        if (i > K)
            return;
        for (j = after + 1; j <= N; j++)
        {
            numbersArray[i - 1] = (int)j;
            if (i == K)
            {
                Print(i);
            }
            Komb(i + 1, j);
        }
    }
    static int Main()
    {
        Console.Write("Please enter N = ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please enter K = ");
        K = int.Parse(Console.ReadLine());
        Console.Write("C({0:D},{1:D}): \n", N, K);
        Komb(1, 0);
        return 0;
    }
}