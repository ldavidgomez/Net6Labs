namespace EventsAndDelegates;

public class UserEventArgs : EventArgs
{
    public User User { get; set; }
}
public class UserProcessor
{
    public event EventHandler<UserEventArgs> UserProcessed;
        
    public void Process(User user)
    {
        Console.WriteLine("Processing User...");
        Thread.Sleep(3000);
            
        OnUserProcessed(user);
    }

    protected virtual void OnUserProcessed(User user)
    {
        UserProcessed(this, new UserEventArgs(){User = user});
    }
}