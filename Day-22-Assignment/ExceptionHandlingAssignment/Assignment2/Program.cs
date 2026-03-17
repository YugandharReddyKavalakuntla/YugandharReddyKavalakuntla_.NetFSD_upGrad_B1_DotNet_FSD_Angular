
class Program
{
    static void Main()
    {
        MovieBooking obj = new MovieBooking();

        Console.Write("Do you want to book tickets? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter number of tickets: ");
            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                obj.BookTickets(n);
            }
            catch (TicketLimitException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Booking cancelled.");
        }
    }
}