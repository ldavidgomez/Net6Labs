namespace EventsAndDelegates;

partial class Program
{
    static void Main(string[] args)
    {
        var user = User.Create("Bob", "Smith", "Bobs home address");
        var userProcessor = new UserProcessor(); //publisher
        var emailService = new EmailService(); //subscriber
        var messageService = new MessageService(); //subscriber

        userProcessor.UserProcessed += emailService.OnUserProcessed;
        userProcessor.UserProcessed += messageService.OnUserProcessed;
        
        userProcessor.Process(user);
    }
}