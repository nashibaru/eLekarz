using System.Windows.Controls;
using System.Windows.Input;

namespace eLekarz.Views;

public partial class Login : UserControl
{
    public Login() => InitializeComponent();

    private void EmailMouseDown(object sender, MouseButtonEventArgs e) => tblockemail.Focus();
    private void PasswordMouseDown(object sender, MouseButtonEventArgs e) => tblockpassword.Focus();
}
