namespace eLekarz.Models;

public class UserModel
{
    public string Firstname { get; }
    public string Lastname { get; }
    public DateTime Birthdate { get; }
    public string Email { get; }
    public string Passw { get; }

    public UserModel(string firstname, string lastname, DateTime birthdate, string email, string passw)
    {
        Firstname = firstname;
        Lastname = lastname;
        Birthdate = birthdate;
        Email = email;
        Passw = passw;
    }
}
