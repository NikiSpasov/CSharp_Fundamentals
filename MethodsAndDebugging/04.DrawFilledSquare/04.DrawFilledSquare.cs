using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        DrawFilledSquare(n);
    }

    private static void DrawFilledSquare(int n)
    {
        DrawFirstLine(n);
        DrawBody(n);
        DrawLastLine(n);
    }

    private static void DrawFirstLine(int n)
    {
        Console.WriteLine(new string('-', (2 * n)));
    }

    private static void DrawBody(int n)
    {
        for (int j = 0; j < n - 2; j++)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");

        }   
    }

    private static void DrawLastLine(int n)
    {
        Console.WriteLine(new string('-', (2 * n)));
    }
}
