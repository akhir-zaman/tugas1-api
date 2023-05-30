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

namespace tugas1API
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static string loginEmail;
        public static string loginPass;

        public Login()
        {
            InitializeComponent();
        }

        private void lblDaftar_Click(object sender, RoutedEventArgs e)
        {
            regis register = new regis();
            register.Show();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            loginEmail = logEmail.Text;
            loginPass = logPass.Password;

            if (loginEmail != regis.email)
            {
                MessageBox.Show("Email Salah");
                return;
            }
            if(loginPass != regis.password)
            {
                MessageBox.Show("Password salah");
                return;
            }
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
