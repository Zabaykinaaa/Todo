using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void BackButton_Click (object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        public void UserName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "Введите имя пользователя")
            {
                UserName.Text = "";
                UserName.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void UserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                UserName.Text = "Введите имя пользователя";
            }
        }

        public void Mail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "exam@yandex.ru")
            {
                Mail.Text = "";
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void Mail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "")
            {
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                Mail.Text = "exam@yandex.ru";
            }
        }

        public void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "Введите пароль")
            {
                Password.Text = "";
                Password.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                Password.Text = "Введите пароль";
            }
        }

        public void ConfirmPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ConfirmPassword.Text == "Повторите пароль")
            {
                ConfirmPassword.Text = "";
                ConfirmPassword.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void ConfirmPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ConfirmPassword.Text == "")
            {
                ConfirmPassword.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                ConfirmPassword.Text = "Повторите пароль";
            }
        }
    }
}
