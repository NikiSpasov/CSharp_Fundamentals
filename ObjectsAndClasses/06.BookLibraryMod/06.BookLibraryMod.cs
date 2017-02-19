using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lib
{
    class Program
    {
        static void Main()
        {
            List<Books> myBooks = GetBooks();
            string date = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Library myLib = new Library { Name = "SomeLibrary", Books = myBooks };
            PrintBooks(myLib, startDate);
        }

        private static void PrintBooks(Library myLyb, DateTime startDate)
        {
            foreach (var book in myLyb.Books.Where(x => x.ReleaseDate > startDate).OrderBy(x => x.ReleaseDate).ThenBy(y => y.Title))
            {
                Console.WriteLine($"{book.Title} -> " + book.ReleaseDate.ToString("dd.MM.yyyy"));
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
}
