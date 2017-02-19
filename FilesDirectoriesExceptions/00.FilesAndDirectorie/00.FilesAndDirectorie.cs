using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {

        //INPUT
        string file = File.ReadAllText("file.txt"); //чете всичко и връща стринг!
        string[] fileArr = File.ReadAllLines("file.txt"); //чете всичко и прави масив/колекция от редовете!
        Console.WriteLine(file);
        Console.WriteLine(string.Join(" ", fileArr));
 
        //OUTPUT
        File.WriteAllText("output.txt", "Files are fun!"); //създава файл output.txt със съдържанието между кавичките, следващи запетаята
        File.WriteAllLines("outputFromFile.txt", fileArr); //взима колекция и всеки елемент на нов ред го слага//

        File.AppendAllText("outputFromFile.txt", "Kire"); // добавя след текста на файла тескта в кавичките;
        File.AppendAllLines("outputFromFile.txt", fileArr); //добавя колекция към съществуващ файл()колекция?


        FileInfo fileInfo = new FileInfo("file.txt"); //дава информация за файла!
        var a = fileInfo.Directory;
        Console.WriteLine(a);


        //Directory Class

        Directory.CreateDirectory("Test");
        Directory.Delete("Test"); //трие само ако директорията е празна;
        Directory.Move("Test", "New Foder");
        Directory.GetFiles("Test"); //връща масив от стрингове сфайловете и пътищата;
        Directory.GetDirectories("Test"); //връща субдиректориите и пътищата;
    }
}
