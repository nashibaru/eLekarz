using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace eLekarz.Extras;

public partial class PasswBind : UserControl
{
    private bool _isPasswordChanging;

    public static readonly DependencyProperty PasswordProperty =
        DependencyProperty.Register("Password",
                                    typeof(string),
                                    typeof(PasswBind),
                                    new FrameworkPropertyMetadata(
                                        string.Empty,
                                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                                        PasswordPropertyChanged,
                                        null,
                                        false,
                                        UpdateSourceTrigger.PropertyChanged));

    private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is PasswBind passw)
        {
            passw.UpdatePassword();
        }
    }

    public string Password
    {
        get => (string)GetValue(PasswordProperty);
        set { SetValue(PasswordProperty, value); }
    }

    public PasswBind() => InitializeComponent();

    private void passwBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        _isPasswordChanging = true;
        Password = passwBox.Password;
        _isPasswordChanging = false;
    }

    private void UpdatePassword()
    {
        if (!_isPasswordChanging)
        {
            passwBox.Password = Password;
        }
    }
}
