namespace eLekarz.Models;

public class AppManager
{
    private readonly UserList _userList;

    public string AppName { get; }

    public AppManager(string appName)
    {
        AppName = appName;
        _userList = new();
    }

    public void MakeAccount(UserModel user)
    {
        _userList.AddUser(user);
    }
}
