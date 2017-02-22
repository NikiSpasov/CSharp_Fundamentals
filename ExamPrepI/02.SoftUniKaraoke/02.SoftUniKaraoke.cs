using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    private static List<Singer> ListSingers()
    {
        var singers = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        var songs = Console.ReadLine()
            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        var input = Console.ReadLine();

        List<Singer> singersList = new List<Singer>();
        while (input != "dawn")
        {
            List<string> performance = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            Singer currentSinger = new Singer();

            currentSinger.Name = performance[0];
            currentSinger.Song = performance[1];
            string award = performance[2];
            currentSinger.Awards = new List<string>();
            currentSinger.Awards.Add(award);

            if (singers.Contains(currentSinger.Name) && songs.Contains(currentSinger.Song))
            {
                singersList.Add(currentSinger);
            }  

            input = Console.ReadLine();

        }
        return singersList;

    }
    static void Main()
    {

        List<Singer> singers = ListSingers();

    }

}
//        if (singersList.Count == 0)
//        {
//            Console.WriteLine("No awards");
//        }
//        else
//        {

//        }
//    }
//}
