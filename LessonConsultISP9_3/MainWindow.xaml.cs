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

namespace LessonConsultISP9_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            Win2 w2 = new Win2();
            this.Hide();
            w2.ShowDialog();
            this.Show();
        }

        private void txtLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLogin.Foreground = Brushes.Black;
            if(txtLogin.Text == "Введите логин")
                txtLogin.Clear();            
        }

        private void txtLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Введите логин";
                txtLogin.Foreground = Brushes.Gray;
            }
        }
    }
}
