namespace Exercise1._0;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"{book.Title} by {book.Author} has been added to the library.");
    }

    public void BorrowBook(string title)
    {
        Book book = books.Find(b => { return b.Title == title; });
        if (book != null)
        {
            book.Borrow();
        }
        else
        {
            Console.WriteLine($"Book titled {title} is not found in the library.");
        }
    }

    public void ReturnBook(string title)
    {
        Book book = books.Find(b => { return b.Title == title; });
        if (book != null)
        {
            book.Return();
        }
        else
        {
            Console.WriteLine($"Book titled {title} is not found in the library.");
        }
    }

    public void ListBooks()
    {
        int i = 0;
        Console.WriteLine("Books available in the library:");
        foreach (var book in books)
        {
            string status = book.IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"{++i} {book.Title} by {book.Author} ({status})");
        }
    }
}
