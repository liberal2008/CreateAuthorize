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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        DBContainer dB = new DBContainer();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Password == "" || LastName.Text == "" || FirstName.Text == "" || MiddleName.Text == "")
            {
                MessageBox.Show("Пустые поля");
                return;
            }
            if (dB.Users.Select(item => item.Login).Contains(Login.Text))
            {
                MessageBox.Show("Такой логин уже существует в системе");
                return;
            }
            User newUser = new User()
            {
                Login = Login.Text,
                Password = Password.Password,
                LastName = LastName.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text
            };
            dB.Users.Add(newUser);
            dB.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались");
            AuthorizationWindow aw = new AuthorizationWindow();
            aw.Show();
            this.Close();
        }
        private void CanselClick(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow aw = new AuthorizationWindow();
            aw.Show();
            this.Close();
        }
             
    }
}
