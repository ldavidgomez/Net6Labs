namespace EventsAndDelegates;

public class EmailService
{
    public void OnUserProcessed(object source, UserEventArgs e)
    {
        Console.WriteLine("EmailService: User processed " + e.User.Name);
    }
}