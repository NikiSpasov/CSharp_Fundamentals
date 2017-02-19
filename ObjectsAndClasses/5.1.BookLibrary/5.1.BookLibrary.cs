using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
        Library myLib = new Library { Name = "SomeName", Books = GetBooks() };
        PrintMyLib(myLib);
    }

    private static void PrintMyLib(Library myLib)
    {
        foreach (var book in myLib.Books
            .GroupBy(x => x.Author)
            .OrderByDescending(x => x.Sum(y => y.Price))
            .ThenBy(z => z.Key))
        {
            Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):f2}");
        }
    }

    private static List<Books> GetBooks()
    {
        int num = int.Parse(Console.ReadLine());
        List<Books> myBooks = new List<Books>();
        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Books currentBook = new Books
            {
                Author = input[1],
                Title = input[0],
                Publisher = input[2],
                Price = double.Parse(input[5]),
                ReleaseDate = DateTime.ParseExact(input[3],
                "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = input[4]
            };
            myBooks.Add(currentBook);
        }
        return myBooks;
    }
}

