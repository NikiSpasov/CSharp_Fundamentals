using System;

class Program
{
    static void Main()
    {
        int numOfPeople = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        int result = (int)Math.Ceiling((double)numOfPeople / capacity);
        Console.WriteLine(result);
    }
}
