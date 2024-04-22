using eLekarz.Models;
using eLekarz.Stores;
using eLekarz.ViewModels;
using System.Windows;

namespace eLekarz;

public partial class App : Application
{
    private readonly AppManager _appManager;
    private readonly NavigationStore _navigationStore;
    public App()
    {
        _appManager = new AppManager("eLekarz");
        _navigationStore = new NavigationStore();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore, CreateRegisterViewModel);

        MainWindow = new MainWindow()
        {
            DataContext = new MainViewModel(_navigationStore)
        };
        MainWindow.Show();

        base.OnStartup(e);
    }

    private RegisterViewModel CreateRegisterViewModel() => new RegisterViewModel(_appManager, _navigationStore, CreateLoginViewModel);

    private LoginViewModel CreateLoginViewModel() => new LoginViewModel(_navigationStore, CreateRegisterViewModel);
}
