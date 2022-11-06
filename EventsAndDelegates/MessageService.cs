namespace EventsAndDelegates;

    public class MessageService
    {
        public void OnUserProcessed(object source, UserEventArgs e)
        {
            Console.WriteLine("MessageService: User processed " + e.User.Name);
        }
    }