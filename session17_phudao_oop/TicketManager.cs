class TicketManager
{
    private List<Ticket> tickets = new List<Ticket>();
    private static int ticketCount = 1; // tạo ID cho ticket

    public Ticket createTicket(Movie movie, Customer customer, double price)
    {
        string ticketID = "T" + ticketCount;
        ticketCount++;

        Ticket ticket = new Ticket(ticketID, movie, customer, price);
        tickets.Add(ticket);
        return ticket;
    }

    public void displayTicket()
    {
        Console.WriteLine("Ticket: ");
        foreach (Ticket ticket in tickets)
        {
            ticket.displayTicket();
        }
    }
}