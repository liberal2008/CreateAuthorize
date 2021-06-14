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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        public string defLogin = "login";
        public string defPassword = "123";

        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            string login = login2.Text;
            string password = password2.Password;
            if (login == defLogin && password == defPassword)
            {
                MessageBox.Show("Вы успешно авторизировались!");
            }
            else { 
                MessageBox.Show("Ошибка авторизации");
            }
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }
