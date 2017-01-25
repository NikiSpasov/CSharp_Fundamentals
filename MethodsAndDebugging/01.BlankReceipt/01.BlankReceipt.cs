using System;


class Program
{
    public static void PrintLogo()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    private static void PrintFooter()
    {
        Console.WriteLine("------------------------------\n\u00A9 SoftUni");
    }

    private static void PrintBody()
    {
        Console.WriteLine("Charged to____________________\nReceived by___________________");
    }

    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT\n------------------------------");
    }

    static void Main()
    {
        PrintLogo();
    }
}

