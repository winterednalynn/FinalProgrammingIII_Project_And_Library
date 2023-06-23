using FinalProgrammingIII;
using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProgrammingIII
{
    internal static class Data
    {
        public static UserAccount currentAccount;
        private static List<UserAccount> accounts = new List<UserAccount>();
        static string accountInformation = "users.json";
        static string transactionextension = "_transaction.csv";

        public static List<UserAccount> Accounts { get => accounts; set => accounts = value; }

        static Data()
        {
            LoadAccounts(); 
        }

        public static void Preload() //Used to load accounts list the first then save to .jason 
        {
            //ADD PROFESSIONAL ARTIST 
            accounts.Add(new UserAccount("Gamora", "Gamora", "Gamora", UserAccount.Role.ProfessionalArtist));
            accounts.Add(new UserAccount("Nebula", "Nebula", "Nebula", UserAccount.Role.ProfessionalArtist));
            accounts.Add(new UserAccount("Groot", "Groot", "Groot", UserAccount.Role.ProfessionalArtist));
            accounts.Add(new UserAccount("Star-Lord", "Star-Lord", "Star-Lord", UserAccount.Role.ProfessionalArtist));

            //ADD BEAUTYSTUDENTS: 
            accounts.Add(new UserAccount("Loki", "Loki", "Loki", UserAccount.Role.BeautyStudent));
            accounts.Add(new UserAccount("Rocket Raccoon", "Rocket Raccoon", "Rocket Raccoon", UserAccount.Role.BeautyStudent));
            accounts.Add(new UserAccount("Vision", "Vision", "Vision", UserAccount.Role.BeautyStudent)); 
            accounts.Add(new UserAccount("Storm", "Storm", "Storm",UserAccount.Role.BeautyStudent));

            SaveAccounts(); 
            

        }

        public static void SaveAccounts()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonManager = JsonSerializer.Serialize(accounts, jso);
            File.WriteAllText(accountInformation, jsonManager);
        }
        public static void LoadAccounts()
        {
            
            string listFromFile = File.ReadAllText(accountInformation);
            accounts = JsonSerializer.Deserialize<List<UserAccount>>(listFromFile);
        }

    }
}

//public static useraccount currentuser;

//public static list<useraccount> accounts = new list<useraccount>();

//public static string userinformation = "users.json";
//static string transactionextension = "_transaction.csv";

//use a static constructor to load the accounts list ( make sure a file exist before you try to load )
//static data()
//{
//    readusers();
//}

//special method with provided code ( helps save a file with the users name and transaction )
// this creates a unique file automatically based on the user account that's logged in

//public static string userstransactions()
//{
//    return currentuser.name + transactionextension;
//}

//public static void preload() // used to load accounts list the first time, then save to .json

//        public static void adduser(useraccount account) // add user to accounts and then save to json

//        public static void saveusers() // save accounts json

//        public static void readusers() // read json and deserialize to accounts
