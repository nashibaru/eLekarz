using eLekarz.Commands;
using eLekarz.Models;
using eLekarz.Stores;
using System.Windows.Input;

namespace eLekarz.ViewModels;

public class RegisterViewModel : ViewModelBase
{
    private string _firstname;
    private string _lastname;
    private DateTime _birthdate;
    private string _email;
    private string _passw;
    private readonly string _cpassw;
    public string Firstname
    {
        get => _firstname;
        set
        {
            _firstname = value;
            OnPropertyChanged(nameof(Firstname));
        }
    }

    public string Lastname
    {
        get => _lastname;
        set
        {
            _lastname = value;
            OnPropertyChanged(nameof(Lastname));
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    public string Passw
    {
        get => _passw;
        set
        {
            _passw = value;
            OnPropertyChanged(nameof(Passw));
        }
    }

    public string CPassw
    {
        get => _cpassw;
        set
        {
            _passw = value;
            OnPropertyChanged(nameof(CPassw));
        }
    }

    public DateTime Birthdate
    {
        get => _birthdate;
        set
        {
            _birthdate = value;
            OnPropertyChanged(nameof(Birthdate));
        }
    }

    public ICommand SignUpCommand { get; }
    public ICommand BackToLoginCommand { get; }

    public RegisterViewModel(AppManager appManager, NavigationStore navigationStore, Func<LoginViewModel> createLoginViewModel)
    {
        SignUpCommand = new RegisterCommand(this, appManager);
        BackToLoginCommand = new NavigateCommand(navigationStore, createLoginViewModel);
    }
}
