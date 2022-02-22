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
using Banks.Clasess;
using Banks.Clasess.Models;

namespace Banks.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            var user = DatabaseModel.db.NamesClients.First(x => (x.login == loginTextBox.Text && x.password == passwordBox.Password));
            
            if ( user ==null)
            {
                warningPopup.IsOpen = true;
            }
            else
            {
                ClientsModel.Login = user.login;
                ClientsModel.Password = user.password;
                ClientsModel.Fullname = user.fname;
                ClientsModel.id_name = user.id;
                ClientsModel.Adress = user.adress;
                MainFrameModel.thisframe.Navigate(new MainPage());
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            warningPopup.IsOpen = true;
        }
    }
}
