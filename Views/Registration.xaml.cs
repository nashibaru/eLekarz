using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Telemedycyna.Models;

namespace Telemedycyna.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        public Registration() => InitializeComponent();

        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ChangedButton == MouseButton.Left)
        //        this.DragMove();
        //}

        private void Button_Signup(object sender, RoutedEventArgs e)
        {
            string firstName = fNameTBox.Text;
            string lastName = lNameTBox.Text;
            string email = EmailTBox.Text;
            string password = PassTBox.Password;
            string dateOfBirth = DateOfBirthPicker.SelectedDate?.ToShortDateString();

            if (string.IsNullOrEmpty(firstName)
            || string.IsNullOrEmpty(lastName)
            || string.IsNullOrEmpty(email)
            || string.IsNullOrEmpty(password)
            || string.IsNullOrEmpty(dateOfBirth))
            {
                StatusTextBlock.Text = "Please fill in all fields.";
            }
            else
            {
                if (ValidateData(email, password))
                {
                    using (var db = new eLekarzEntities())
                    {
                        var user = new User { FirstName = firstName, LastName = lastName, BirthDate = DateTime.Parse(dateOfBirth), Email = email, Pass = password };
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                }
                else StatusTextBlock.Text = "Cannot sign up!";
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private bool ValidateData(string email, string password)
        {
            if (!IsValidEmail(email))
            {
                StatusTextBlock.Text = "Invalid email format!\n";
                return false;
            }

            if (!IsValidPassword(password))
            {
                StatusTextBlock.Text = "Password must contain at least 8 characters - numbers and letters!\n";
                return false;
            }

            if (password != cPassTBox.Password)
            {
                StatusTextBlock.Text = "Passwords are not equal!\n";
                return false;
            }

            else
            {
                StatusTextBlock.Text = "Account created!";
                return true;
            }
        }
    }
}
