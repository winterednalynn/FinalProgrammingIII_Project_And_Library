using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProgrammingIII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<UserAccount> professionaluser = new List<UserAccount>();
        UserAccount useraccounts = new UserAccount();
        ProfessionalArtist _professionalpage = new ProfessionalArtist();


        public MainWindow()
        {
            InitializeComponent();

            professionaluser.Add(new UserAccount("Gamora", "Gamora", "Gamora", UserAccount.Role.BeautyStudent));
            

        }        

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text; 
            string password = txtPassword.Text; 

            if(IsValidUser(userName, password))
            {
                foreach (UserAccount accounts in professionaluser)
                {
                    if(userName == accounts.UserName && password == accounts.Password)
                    {
                        _professionalpage.Show(); 
                    }
                }
            }


        }

        public bool IsValidUser(string user, string password)
        {
            foreach (UserAccount accounts in professionaluser)
            {
                if(user == accounts.UserName && password == accounts.Password)
                {
                    return true; 
                }
            }
            return false; 
        }   
    }
}
