using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int totalPics = int.Parse(Console.ReadLine());
        int timeInSecsForEveryPic = int.Parse(Console.ReadLine());
        double percentOfGoodPics = double.Parse(Console.ReadLine());
        int timeInSecsToUpload = int.Parse(Console.ReadLine());

        double goodPics = (int)Math.Ceiling(totalPics * (percentOfGoodPics / 100));
        var uploadSeconds = goodPics * timeInSecsToUpload;
        double filterSeconds = totalPics * timeInSecsForEveryPic;

        var totalSeconds = filterSeconds + uploadSeconds;

        var totalTime = new TimeSpan(0, 0, (int)totalSeconds);
        Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));

    }
}