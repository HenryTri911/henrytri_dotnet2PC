class Library
{
    
    public string libraryId;
    public string libraryName;
    public List<Book> books;

    public Library (string libraryId, string libraryName)
    {
        this.libraryId=libraryId;
        this.libraryName=libraryName;
        this.books = new List<Book>();
    }
   
    public void addBook (Book book) 
    {
        books.Add(book);
        Console.WriteLine($"Books {book.bookName} added to class {libraryName}");
    }

    public void showBook ()
    {
        Console.WriteLine($"\n -----Book in class {libraryName}-----");
        foreach (Book book in books)
        {
            book.bookInfo();
        }
    }
    public void findBook (string bookID)
    {
        foreach (Book book in books)
        {
            if(book.bookID==bookID)
            {
                book.bookInfo();
                return;
            }
        }
        Console.WriteLine($"Student with ID {bookID} not found in class {libraryName}");
    }
}