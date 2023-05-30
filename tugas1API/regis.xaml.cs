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
    /// Interaction logic for regis.xaml
    /// </summary>
    public partial class regis : Window
    {
        public static string namaDepan;
        public static string namaBelakang;
        public static string email;
        public static string password;
        public static string konfirm;

        public regis()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            namaDepan = txtNamaDepan.Text;
            namaBelakang = txtNamaBelakang.Text;
            email = txtEmail.Text;
            password = pass1.Password;
            konfirm = konfpass.Password;
            if (email == "" && namaBelakang == "" && namaDepan == "" && password == "" && konfirm == "")
            {
                MessageBox.Show("Field tidak boleh kosong!");
            }
            else
            {

                if (password != konfirm)
                {
                    MessageBox.Show("Password tidak sesuai");
                    return;
                }
                else
                {
                    Close();
                    MessageBox.Show("Registrasi berhasil");
                }
            }
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNamaDepan.Text = "";
            txtNamaBelakang.Text = "";
            txtEmail.Text = "";
            pass1.Password = "";
            konfpass.Password = "";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
