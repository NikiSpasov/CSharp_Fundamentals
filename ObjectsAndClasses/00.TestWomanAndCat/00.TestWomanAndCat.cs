using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _00.TestWomanAndCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            Cat secondCat = new Cat();
            Cat thirdCat = new Cat();

            firstCat.Name = "Ivan";

            var name = firstCat.Name;
            Console.WriteLine(name);

            Cat simplifiedCat = new Cat //по-кратък начин за задаване на пропъртита;
            {
                Name = "Mury",
                Age = 4,
                Color = "Yellow",
                isAsleep = false
            };

            //var intro = simplifiedCat.SayMiau();
            //Console.WriteLine(intro);

            Console.WriteLine(firstCat.isAsleep);//false
            firstCat.GoToSleep();//тук се сменя
            Console.WriteLine(firstCat.isAsleep);//true

            WebClient giveMeFail = new WebClient();
            giveMeFail.DownloadFile("https://s-media-cache-ak0.pinimg.com/originals/98/c7/ff/98c7ff782f1848068bb33d5bf4f39215.jpg", "land.jpg");
        }
    }
}
