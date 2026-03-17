using System;


class TicketLimitException : Exception
{
    public TicketLimitException(string message) : base(message)
    {
    }
}

class MovieBooking
{
    int availableTickets = 15;

    public void BookTickets(int tickets)
    {
        if (tickets > availableTickets)
        {
            throw new TicketLimitException("Tickets exceed available limit (15)!");
        }
        else
        {
            availableTickets -= tickets;
            Console.WriteLine("Booking successful!");
            Console.WriteLine("Remaining tickets: " + availableTickets);
        }
    }
}
