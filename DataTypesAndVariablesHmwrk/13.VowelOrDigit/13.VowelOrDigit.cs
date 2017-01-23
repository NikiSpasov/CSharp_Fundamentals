using System;

class Program
{
    static void Main()
    {
        char checkMe = char.Parse(Console.ReadLine());
        int i = (int)(checkMe - 0);
        if (i > 47 && i < 58)
        {
            Console.WriteLine("digit");
            return;
        }
        else if (i == 97 || i == 101 || i == 105 || i == 111 || i == 117 ||
            i == 85 || i == 79 || i == 73 || i == 69 || i == 65)
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
