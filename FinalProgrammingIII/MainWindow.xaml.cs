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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProgrammingIII
{//EDNA LYNN LAXA 
 //PROGRAMMING III FINAL 
 //JUNE 17,2023 
    public partial class MainWindow : Window
    {
        List<UserAccount> theAccounts = new List<UserAccount>();
        //UserAccount useraccounts = new UserAccount();
        ProfessionalArtist pArtist = new ProfessionalArtist(); 


        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            theAccounts.Add(new UserAccount("MaryJane", "MaryJane", "MaryJane", UserAccount.Role.ProfessionalArtist));
            theAccounts.Add(new UserAccount("Goblin", "Goblin", "Goblin", UserAccount.Role.BeautyStudent));

            string userName = txtUserName.Text; //valuing string userName via txt box for userName 
            string password = txtPassword.Text; //valuing string password via txt box for password 

            UserAccount userAccount = ReturnUser(userName, password); //During lesson; learned the power of method. Created a structure where the User is returned per Parameters of the corresponding UserAccount instances. 
            Data.currentAccount = userAccount; //apply Data's current account onto userAccount 

            // What are the two STATES that userAccount can be in?
            // useraccount
            // null - empty

            //// If statement runs IF there is a user account that is not null (!=) 
            if (userAccount != null) // Dividing type of roles into its own window prompt. 
            {
                if (userAccount.Role1 == UserAccount.Role.ProfessionalArtist) 
                    new ProfessionalArtist().Show();
                else
                    new BeautyStudent().Show();
            }

        
        }

        public bool IsValidUser(string user, string password) //Method that check if user is valid. 
        {
            foreach (UserAccount accounts in theAccounts) // Goes through the UserAccount list to spot the corresponding properties to prompt a true action. 
            {
                if (user == accounts.UserName && password == accounts.Password)
                {
                    return true;
                }
            }
            return false;
        }
        
        public UserAccount ReturnUser(string user, string password) //Method made to return user value from U. Account. 
        {

            foreach (UserAccount account in theAccounts) //Prompts comp to go through the llist for UserAccount 
            {
                if (user == account.UserName && password == account.Password)
                {
                    return account;
                }
            }

            return null;
        }
    }

    //*** My original thought process, it works but was taught an alternative method to get the same result// 
    //if (IsValidUser(userName, password))
    //{
    //    foreach (UserAccount accounts in professionaluser)
    //    {

    //        if (userName == accounts.UserName && password == accounts.Password)
    //        {
    //            if(accounts.Role1 == UserAccount.Role.ProfessionalArtist)
    //            {
    //                _professionalpage.Show();
    //            }
    //            else
    //            {
    //                new BeautyStudent().Show();
    //            }

    //        }
    //    }
    //}
}
