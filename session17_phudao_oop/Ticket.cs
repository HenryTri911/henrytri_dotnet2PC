using System.Runtime.CompilerServices;

class Ticket
{
    private string ticketID;
    public string TicketID
    {
        get { return ticketID; }
        set { ticketID = value; }
    }

    private Movie movie;
    public Movie Movie
    {
        get { return movie; }
        set { movie = value; }
    }

    private Customer customer;
    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Ticket(string ticketID, Movie movie, Customer customer, double price)
    {
        TicketID = ticketID;
        Movie = movie;
        Customer = customer;
        Price = price;
    }

    public void displayTicket()
    {
        Console.WriteLine("Ticket ID:" + TicketID);
        Console.WriteLine("Movie:" + Movie.Title);
        Console.WriteLine("Customer:" + Customer.Name);
        Console.WriteLine("Price:" + Price);
    }
}