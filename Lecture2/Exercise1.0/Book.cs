namespace Exercise1._0;

public class Book
{
    public string Title;
    public string Author;
    public bool IsBorrowed;

    public Book(string Title, string Author)
    {
        this.Title = Title;
        this.Author = Author;
        this.IsBorrowed = false;
    }

    public void Borrow()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"{Title} has been borrowed");
        }
        else
        {
            Console.WriteLine($"{Title} is already borrowed");
        }
        Console.WriteLine();
    }

    public void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"{Title} has been returned");
        }
        else
        {
            Console.WriteLine($"{Title} was not borrowed");
        }
        Console.WriteLine();
    }
}
