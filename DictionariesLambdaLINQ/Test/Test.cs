using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main()
        {

            //Създаване на речник със стрингове, присвояване
            //на int към променлива, разпечатване на всички;

            Dictionary<string, int> studentMarks = new Dictionary<string, int>();
            studentMarks.Add("Ivan", 5);
            studentMarks.Add("Dragan", 6);
            studentMarks.Add("Mariika", 6);
            studentMarks.Add("Lilia", 7);

            //int ivanMarks = studentMarks["Ivan"];
            //int mariikaMark = studentMarks["Mariika"];
            //Console.WriteLine(ivanMarks);
            //Console.WriteLine(mariikaMark);

            //foreach (var student in studentMarks)
            //{
            //    Console.WriteLine($"The student {student.Key} has {student.Value}!");
            //    Console.WriteLine(student);//отпечатва ги по двойки!
            //}


            //проверка дали такъв ключ или такава стойност /Key or Value/ се съдържа в речника:
            //bool isThereKey = studentMarks.ContainsKey("Mariika");  //такъв ключ /Key;
            //bool isThereValue = studentMarks.ContainsValue(2); //такава стойност /Value;
            //Console.WriteLine(isThereKey);
            //Console.WriteLine(isThereValue);


            //Преброяване на думите в текст:
            //string text = "Some text, more text, any text for a test of MF dictionaries";
            //Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            //string[] words = text.Split(',', ' ', '.');
            //foreach (string word in words)
            //{
            //    int count = 1;
            //    if (wordsCount.ContainsKey(word)) //ключа ако го има:
            //    {
            //        count = wordsCount[word] + 1;//значи още веднъж го добави към каунтъра за съответната дума, 
            //                                     //т.е. вече думата я има два пъти, три пъти и т.н. 
            //                                     //В случая wordCount[word] e int, число, което се променя!;
            //    }
            //    wordsCount[word] = count; //ако го няма - инициализирай го.
            //}
            //foreach (var pair in wordsCount)
            //{
            //    Console.WriteLine($"{pair.Key} --> {pair.Value}");

            //}

            //int count = studentMarks.Count;
            //Console.WriteLine(count); //колко двойки елемента има в речника;
            //var keys = studentMarks.Keys; //тук keys е колекция!
            //var values = studentMarks.Values;
            //за да се разпечата колекцията и да се види:
            //foreach (var item in keys) //разпечатва ключовете
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var val in values) //разпечатва сойностите
            //{
            //    Console.WriteLine(val);
            //}

            //MEHODS: ContainsKey(), ContainsValue(), TryGetValue();

            //bool isIvanThere = studentMarks.ContainsKey("Ivan");
            //Console.WriteLine(isIvanThere);//True;
            //isIvanThere = studentMarks.ContainsKey("Io");
            //Console.WriteLine(isIvanThere);//False
            //bool is7inTheValues = studentMarks.ContainsValue(7);
            //Console.WriteLine(is7inTheValues);//True

            //int num;
            //studentMarks.TryGetValue("Ivan", out num);
            //Console.WriteLine(num); //ако има "Ivan" в речника, то записва стойността му в "num";
            //в този случай num = 5;
            //Ако няма такъв ключ:
            //studentMarks.TryGetValue("Ivankovica", out num);
            //Console.WriteLine(num);//тук е нула, т.е. дифолта на типа!


            //*По същия начин и TryParse:
            //string a = Console.ReadLine();
            //int c;
            //bool b = int.TryParse(a, out c);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //METHOD REMOVE:

            //studentMarks.Remove("Ivan");
            //foreach (KeyValuePair<string, int> item in studentMarks)
            //{
            //    Console.WriteLine(item);
            //}
            //[Dragan, 6]
            //[Mariika, 6]
            //[Lilia, 7] - Ivan го няма!

            //ЕТО КАК СЕ НАМИРА БРОЯ ДУМИ В ЕДИН ТЕКСТ:
            //var words = Console.ReadLine().ToLower().Split(' ');
            //var wordCount = new Dictionary<string, int>();
            //foreach (var word in words)
            //{
            //    if (!wordCount.ContainsKey(word))
            //    {
            //        wordCount[word] = 0;
            //    }
            //    wordCount[word]++;
            //}

            //var result = new List<string>();

            //foreach (var item in wordCount)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        result.Add(item.Key);
            //    }
            //}

            //Console.WriteLine(string.Join(", ", result));

            //СОРТИРАН РЕЧНИК:
            //var sortedDict = new SortedDictionary<string, int>();
            //sortedDict.Add("Ivan", 5);
            //sortedDict.Add("Ivanka", 3);
            //sortedDict.Add("Ivanushka", 4);
            //sortedDict.Add("Iva", 5);

            //foreach (var item in sortedDict)
            //{
            //    Console.WriteLine(item);
            //}
            //RESULT: /- сортира ги по Key:/
            //[Iva, 5]
            //[Ivan, 5]
            //[Ivanka, 3]
            //[Ivanushka, 4]

            //Прочети числа, отпечаай ги във възходящ ред и срещу тях - броя на появяванията им:
            //var numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse);

            //var result = new SortedDictionary<double, int>();

            //foreach (var number in numbers)
            //{
            //    if (!result.ContainsKey(number))
            //    {
            //        result[number] = 0;
            //    }
            //    result[number]++;
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value} times");
            //}

            //Прочети текст и виж коя буква колко пъти се среща:

            //var text = "Ivancho otide na uchilishte i mu pisaha dvojka"
            //    .ToLower()
            //    .Replace(" ", string.Empty); //tuk mahame space-a, moje i bez tova, spored zavisi ;)
            //var result = new SortedDictionary<char, int>();
            //foreach (var symbol in text)
            //{
            //    if (!result.ContainsKey(symbol))
            //    {
            //        result[symbol] = 0;
            //    }
            //    result[symbol]++;
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //L I N Q 


            //List<int> list = new List<int> { 1, 5, 3, 6, 7, 8, 9 };
            //var a = list.Min();
            //var b = list.Max();
            //var c = list.Average();
            //var d = list.Sum();
            //Console.WriteLine(a);//1
            //Console.WriteLine(b);//9
            //Console.WriteLine(c);//5.57
            //Console.WriteLine(d);//39
            //var result = list
            //    .OrderBy(number => number)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//1, 3, 5........
            //}

            //var newDict = new Dictionary<string, int>();
            //newDict.Add("A", 3);
            //newDict.Add("B", 3);
            //newDict.Add("C", 4);
            //newDict.Add("D", 4);
            //newDict.Add("E", 3);

            //var resultDict = newDict
            //    .OrderBy(i => i.Value)
            //    .ThenBy(i => i.Key)
            //    .ToDictionary(i => i.Key, i => i.Value); //изрично да му се посочи кое е ключ и кое е стойност.

            //foreach (var item in resultDict)
            //{
            //    Console.WriteLine(item);
            //}

            ////реди ги по ключ или стойност!

         // METHODS TAKE() and SKIP()

            //List<int> myList = new List<int> { 1, 5, 10, 11, 14, 6, 3, 7, 14 };
            //var result = myList
            //   .OrderBy(n => n)//подрежда ги по големина;
            //   .Take(7);//взима  пъвите 7;

            ////съответно Skip(5) пропукса първите 5 и т.н.

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //METHOD Where(), Count(), Any(), All(), Select(), Distinct()

            //List<int> myList = new List<int> { 1, 5, 10, 11, 14, 6, 3, 7, 14 };

            //var result = myList
            //    .Where(n => n % 2 == 0) //нова колекция result, в която са всички четни числа от стария myList,
            //    //т.е. Where взима само тези, за които са спазени условията и в последствие .ToArray() ги налива в масив.
            //    .ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //};

            //var resultCount = myList.
            //    Count(n => n > 10);
            //Console.WriteLine(resultCount); //отпечатва 3, т.е. БРОЯ НА ЕЛЕМЕНТИТЕ, отговарящи на това условие,в сл. по-големи от 10;

            //var resultAny = myList
            //    .Any(n => n > 2);
            //Console.WriteLine(resultAny); //bool - true ако има поне един елемент по-голям от 2-та или false ако няма такъв;

            //var resultAll = myList
            //    .All(n => n > 0); //bool - ако ВСИЧКИ еементи отговарят на това условие - връща TRUE;
            //Console.WriteLine(resultAll); //True;

            //var resultSelect = myList
            //    .Select(n => 2 * n) //избира на всеки член от редицата какво действие да нму приложи, в случая да го умножи по 2
            //    .ToList();

            //resultSelect.ForEach(Console.WriteLine);

            //myList
            //    .Distinct() //вади само уникалните стойности, т.е. например ако имаме лист с 3, 4, 4, 5, 6, 7, 7, 8
            //    //ще стане 3, 4, 5, 6, 7, 8
            //    .OrderBy(n => n)
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            //METHODS First(), Last(), Single()
            var list = new List<int> { 2, 3, 4, 5, 2, 5, 4, 3, 8 };
            //var first = list
            //    .First(n => n % 2 == 0); // дай ми първия елемент, който е четен!
            //Console.WriteLine(first); //2
            //var last = list.Last(n => n % 2 == 0);
            //Console.WriteLine(last);// дай ми последния елемент, който е четен!
            var single = list.
                Single(n => n < 9 && n > 7);
            //Console.WriteLine(single); //8, ако нямаше 8 - гърми, ако има повече от един елемент, който да отговаря на условията - пак гърми;
            Console.WriteLine(single);

            //С FirstOrDefault, LastOrDefault и SinglеOrDefault - ако го няма, връща дефоултната стойност на типа;

            //METHODS Concat() - залепва, Reverse() - обръща;

        }


    }
}
