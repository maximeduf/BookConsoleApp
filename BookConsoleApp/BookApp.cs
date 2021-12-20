using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConsoleApp;

class BookApp
{
    List<Book> Books { get; set; } = new List<Book>();

    public void Test()
    {
        Books.Add(new Book());
        Books.Add(new Book("Happy Rotter"));
        PrintBooks();

        Thread.Sleep(1000);

        Books[0].Title = "Some Title";
        PrintBooks();
    }

    public void PrintBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
    }
}
