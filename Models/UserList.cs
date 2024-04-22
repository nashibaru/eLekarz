namespace eLekarz.Models;

public class UserList
{
    private readonly List<UserModel> _users;

    public UserList()
    {
        _users = new List<UserModel>();
    }

    public bool UserExists(UserModel user)
    {
        foreach (var item in _users)
        {
            if (item.Email == user.Email) return true;
        }
        return false;
    }

    public void AddUser(UserModel user)
    {
        if (!UserExists(user)) _users.Add(user);
    }
}
