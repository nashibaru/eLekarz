using eLekarz.Models;
using eLekarz.ViewModels;

namespace eLekarz.Commands;

public class RegisterCommand : CommandBase
{
    private readonly AppManager _appManager;
    private readonly RegisterViewModel _registerViewModel;

    public RegisterCommand(RegisterViewModel registerViewModel, AppManager appManager)
    {
        _registerViewModel = registerViewModel;
        _appManager = appManager;
    }

    public override void Execute(object? parameter)
    {
        UserModel userModel = new UserModel(
            _registerViewModel.Firstname,
            _registerViewModel.Lastname,
            _registerViewModel.Birthdate,
            _registerViewModel.Email,
            _registerViewModel.Passw);

        _appManager.MakeAccount(userModel);
    }
}
