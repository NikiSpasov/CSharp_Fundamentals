using System;

class Program
{
    private static void PrintTriangle(int num)
    {
        PrintUpperPartOfTriangle(num);
        PrintBottomPartOfTriangle(num);
    }
    private static void PrintUpperPartOfTriangle(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
    private static void PrintBottomPartOfTriangle(int num)
    {
        for (int i = num; i > 0; i--)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }
}

