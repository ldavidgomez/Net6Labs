namespace EventsAndDelegates;

public class User
{
    private readonly string _name;
    private readonly string _surname;
    private readonly string _address;
    public string Name => _name;
    public string Surname => _surname;
    public string Address => _address;
    private User(string name, string surname, string address)
    {
        _name = name;
        _surname = surname;
        _address = address;
    }

    public static User Create(string name, string surname, string address)
    {
        return new User(name, surname, address);
    }
}