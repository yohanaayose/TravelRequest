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
using TravelRequest.Application;
using TravelRequest.Interfaces;
using TravelRequest.Model;

namespace TravelRequest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MyContext myContext = new MyContext();
        IAccount iAccount = new AccountController ();
        TB_M_Account account = new TB_M_Account();
        IUser iUser = new UserController();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            account.Username = NameUser_Txt.Text;
            account.Password = Password_Box.Password;

            var result = iAccount.InsertAccount(account);
            if (result)
            {
                MessageBox.Show("Insert Success");
                NameUser_Txt.Text = "";
            }
            else
            {
                MessageBox.Show("Failed");
                NameUser_Txt.Text = "";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<TB_M_User> TB_M_Users_Id = iUser.get();
        }
    }
}
