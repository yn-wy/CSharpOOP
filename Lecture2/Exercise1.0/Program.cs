namespace Exercise1._0;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Console.WriteLine("Welcome to Lincoln University Library System");
        Console.WriteLine($"Date & Time: {DateTime.Now}");

        library.AddBook(new Book("Visual C#.Net Programming", "P. Sellappan"));
        library.AddBook(new Book("Visual C++ Programming", "P. Sellappan"));
        library.AddBook(new Book("Visual Basic 6 Programming", "Munir K. Yahya-Imam"));
        library.AddBook(new Book("Object Oriented Programming", "Munir K. Yahya-Imam"));
        library.AddBook(new Book("Database Management System", "Munir K. Yahya-Imam"));

        library.AddBook(new Book("Learn OpenGL", "Joey de Vries"));
        library.AddBook(new Book("Vulkan Programming Guide", "Graham Sellers"));
        library.AddBook(new Book("Game Programming With DX11", "Frank Luna"));
        library.AddBook(new Book("C++ Software Design", "Klaus Iglberger"));
        library.AddBook(new Book("Linear Algebra Done Right", "Sheldon Axler"));

        library.BorrowBook("Learn OpenGL");
        library.BorrowBook("Linear Algebra Done Right");
        library.ReturnBook("Linear Algebra Done Right");

        library.ListBooks();
    }
}
