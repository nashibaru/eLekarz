using System.Windows.Input;
using eLekarz.Commands;
using eLekarz.Stores;

namespace eLekarz.ViewModels;

public class LoginViewModel : ViewModelBase
{
    private string _loginemail;
    private string _loginpassw;

    public string LoginEmail
    {
        get => _loginemail;
        set
        {
            _loginemail = value;
            OnPropertyChanged(nameof(LoginEmail));
        }
    }

    public string LoginPassw
    {
        get => _loginpassw;
        set
        {
            _loginpassw = value;
            OnPropertyChanged(nameof(LoginPassw));
        }
    }

    public ICommand LogInCommand { get; }
    public ICommand GoToRegisterCommand { get; }

    public LoginViewModel(NavigationStore navigationStore, Func<RegisterViewModel> createRegisterViewModel)
    {
        GoToRegisterCommand = new NavigateCommand(navigationStore, createRegisterViewModel);
    }

}
