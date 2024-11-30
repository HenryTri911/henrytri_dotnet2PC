class Book 
{
    public string bookID;
    public string bookName;
    public string author;
    public double price;
    public Book (string bookID, string bookName, string author, double price)
    {
        this.bookID=bookID;
        this.bookName=bookName;
        this.author=author;
        this.price=price;
    }
    public void bookInfo ()
    {
        Console.WriteLine($"Book ID: {bookID}*-*Book name: {bookName}*-*Author: {author}*-*Price: {price}");
    }
}