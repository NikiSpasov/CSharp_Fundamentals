using System;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().
             Split(' ');

        Random rnd = new Random();
        for (int i = 0; i < input.Length; i++)
        {
            var currentWord = input[i];
            var randomIndex = rnd.Next(0, input.Length);
            input[randomIndex] = currentWord;
            var tempword = input[randomIndex];
            input[i] = tempword;
            

        }
        Console.WriteLine(string.Join("\n", input));    
    }
}