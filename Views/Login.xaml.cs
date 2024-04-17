using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Telemedycyna.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login() => InitializeComponent();

        private void Email_mdown(object sender, MouseButtonEventArgs e) => tBoxEmail.Focus();

        private void Email_chg(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxEmail.Text))
                tBlockEmail.Visibility = Visibility.Collapsed;
            else
                tBlockEmail.Visibility = Visibility.Visible;
        }

        private void Passw_mdown(object sender, MouseButtonEventArgs e) => tBoxPassw.Focus();

        private void Passw_chg(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxPassw.Password))
                tBlockPassw.Visibility = Visibility.Collapsed;
            else
                tBlockPassw.Visibility = Visibility.Visible;
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxEmail.Text) && !string.IsNullOrEmpty(tBoxPassw.Password))
                MessageBox.Show("Logged In successfully!");
        }

        //private void Button_GoSignup(object sender, RoutedEventArgs e)
        //{
        //    UserControl w = new Registration();
        //    w.Show();
        //}
    }
}
