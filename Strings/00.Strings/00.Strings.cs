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
            string str1 = "abv";
            string str2 = "cde";
            //int result = string.Compare(str1, str2, true); //true - не взима под внимание главна/малк буква, ако е false - взима;/
            //result = 0 ако са еднакви, 
            //result < 0 ако str1 е преди str2;
            //result > 0 ако str1 e след str2;
            //Console.WriteLine(result); // -1, 'a' е преди 'c';

            //string reslult1 = string.Concat(str1, str2); //конкатенира ги;
            int result = str1.IndexOf("b"); //на кой индекс е буквата; ако го няма дава -1;
            //.indexOf("", 10) - започва да търси от 10-и индекс натам. и за LastindexOf работи!
            Console.WriteLine(result);//1
            //.lastIndexOf = започва отзад напред да го търси;

            //Как да намерим колко пъти се повтара определена буква/фраза 
            // в текст:
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();



        }
    }
}
