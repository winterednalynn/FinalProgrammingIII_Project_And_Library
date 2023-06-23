using MyClassLibrary;
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

namespace FinalProgrammingIII
{
    /// <summary>
    /// Interaction logic for ProfessionalArtist.xaml
    /// </summary>
    public partial class ProfessionalArtist : Window
    {
          
        
        public ProfessionalArtist()
        {
            InitializeComponent();

         

            LVProfessional.ItemsSource = Data.Accounts;

            cbRoles.Items.Add("Professional Artist");
            cbRoles.Items.Add("Beauty Student");
            cbRoles.SelectedIndex = 0;





        }


        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            List <UserAccount> addUser = new List<UserAccount> ();
            string Name = txtName.Text;
            string UserName = txtUName.Text;
            string Password = txtUPassword.Text;
            addUser.Add(new UserAccount(Name, UserName, Password)); 
            LVProfessional.ItemsSource = addUser;
        }

        private void cbRoles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
