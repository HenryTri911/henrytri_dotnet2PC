using System.Diagnostics.Contracts;

class Cinema
{
    private List<Customer> customers = new List<Customer>();
    public List<Customer> Customers
    {
        get { return customers; }
        set { customers = value; }
    }
    private List<Movie> movies= new List<Movie>();
    public List<Movie> Movies
    {
        get { return movies; }
        set { movies = value; }
    }
    private TicketManager ticketManager = new TicketManager();

    // add new customer to list
    public void addCustomer(Customer customer)
    {
        customers.Add(customer);
        Console.WriteLine("Customer added successfully!");
    }
    // add movie to list
    public void addMovie(Movie movie)
    {
        movies.Add(movie);
        Console.WriteLine("Movie added successfully!");
    }
    // add new ticket to customer
    public void bookTicket(Movie movie, Customer customer, double price)
    {
        Ticket ticket = ticketManager.createTicket(movie, customer,price);
        customer.addTicket(ticket);
        Console.WriteLine($"Ticket booked successfully by customer {customer.Name}");
    }
}