using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Strings
{
    class Program
    {
        static void Main()
        {
            //Compare(); x.CompareTo(y);
            //string str1 = "abv";
            //string str2 = "cde";
            //int result = string.Compare(str1, str2, true); //true - не взима под внимание главна/малк буква, ако е false - взима;/
            //result = 0 ако са еднакви, 
            //result < 0 ако str1 е преди str2;
            //result > 0 ако str1 e след str2;
            //Console.WriteLine(result); // -1, 'a' е преди 'c';

            //string reslult1 = string.Concat(str1, str2); //конкатенира ги;
            //int result = str1.IndexOf("b"); //на кой индекс е буквата; ако го няма дава -1;
            //.indexOf("", 10) - започва да търси от 10-и индекс натам. и за LastindexOf работи!
            //Console.WriteLine(result);//1
            //.lastIndexOf = започва отзад напред да го търси;


            //indexOf
            //Как да намерим колко пъти се повтаря определена буква/фраза:


            // в текст:
            //var text = "Tuk e samo Ali Baba - carq Ali, gospodarq Ali";
            //var pattern = "Ali";
            //int cnt = 0;
            //int startIndex = 0;
            //int index = text.IndexOf(pattern, startIndex);
            //while (index >= 0)
            //{
            //    cnt++;
            //    startIndex = index + 1;
            //    index = text.IndexOf(pattern, startIndex);
            //}
            //Console.WriteLine(cnt);//3


            //Text.Replace("", ""), или 
            //Как да намерим определени думи в текст и да ги заменим със звездички:


            //string[] bannedWords = new string[] { "kur", "putka", "made" };
            //string text = "kur putka i made, trimata ot GDR";
            //foreach (var word in bannedWords)
            //{
            //    if (text.IndexOf(word) >= 0)
            //    {
            //       text = text.Replace(word, (new string('*', word.Length)));
            //    }
            //}
            //Console.WriteLine(text);

            //string filename = @"C:\Pics\Rila.jpg";
            //var part = filename.Substring(2);
            //Console.WriteLine(part); //  \Pics\Rila.jpg , т.е. започва от втория включително до края;
            //var mesuredPart = filename.Substring(3, 4);
            //Console.WriteLine(mesuredPart); // Pics, започва от третия, взима 4;

            //str.Remove(int index, int lenght)
            //string filename = @"C:\Pics\Rila.jpg";
            //string cutted = filename.Remove(0, 3);
            //Console.WriteLine(cutted); // \Rila.jpg

            //Trim()
            //string s = "     example of white space     ";
            //string clean = s.Trim();
            //Console.WriteLine(clean); //example of white space, без спейсовете;
            //string s = " \t\nHel ! lo!!! \n";
            //string clean = s.Trim(' ', ',', '!', '\n', '\t');
            //Console.WriteLine(clean); // Hel ! lo - маха всички изброени чарове отзад и отпред!
            //ВАЖНО - не маха чаровете в средата на стринга - виж удивителния!
            //string s = "llll C# llll";
            //string clean = s.TrimStart('l'); // clean = " C# lllll"
            //Console.WriteLine(clean);
            ////сътответноto върши и Trim.End

            //StringBuilder:
            //StringBuilder sb = new StringBuilder();
            ////sb.AppendFormat("{0}, {1}", 1, 2); /добавя ги по определен формат!
            //sb.AppendLine("First Line");
            //sb.AppendLine("Second Line");
            //sb.Append("Some appended text "); //само аппенд добавя към реда, а AppendLine  - добавя нов ред;
            //sb.Append("More text");
            //Console.WriteLine(sb.ToString());
            //.this[int index](indexer in C#) gives access to the char value at given position
            //.Length holds the length of the string in the buffer

            //sb.Append(…) appends a string or another object after the last character in the buffer

            //sb.Remove(int startIndex, int length) removes the
            //characters in given range

            //sb.Insert(int index, string str) inserts given string(or
            //object) at given position


            //sb.Replace(string oldStr, string newStr) replaces all occurrences of a substring

            //sb.ToString() converts the StringBuilder to String


            //как да обърнем един стринг:
            //var a = Console.ReadLine().ToCharArray();
            //Array.Reverse(a);
            //string b = new string (a);
            //Console.WriteLine(b);

        }
    }
}
