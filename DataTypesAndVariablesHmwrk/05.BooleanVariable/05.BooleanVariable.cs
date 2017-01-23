using System;
class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        bool b = Convert.ToBoolean(a);
        if (b == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

