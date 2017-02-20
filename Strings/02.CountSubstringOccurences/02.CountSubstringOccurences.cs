using System;
class StringOccurences
{
    public static void Main()
    {
        var text = Console.ReadLine().ToLower();
        var pattern = Console.ReadLine().ToLower();
        int cnt = 0;
        int startIndex = 0;
        int index = text.IndexOf(pattern, startIndex);
        while (index >= 0)
        {
            cnt++;
            startIndex = index + 1;
            index = text.IndexOf(pattern, startIndex);
        }
        Console.WriteLine(cnt);
    }
}
   