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

            SaveAccounts(); //TESTED & list is prompt to a JSON. 
            

        }
        //JSON (JavaScript Object Notation) is a popular data format used for representing structured data.
        //It's common to transmit and receive data between a server and web application in JSON format.
        public static void SaveAccounts() //Save json method 
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonManager = JsonSerializer.Serialize(accounts, jso);
            File.WriteAllText(accountInformation, jsonManager);
        }
        public static void LoadAccounts() // Load jSon Method 
        {
            
            string listFromFile = File.ReadAllText(accountInformation);
            accounts = JsonSerializer.Deserialize<List<UserAccount>>(listFromFile);
        }

        public static string userTransactions()
        {
            return currentAccount.Name + transactionextension; 
        }
        
        public static void Adduser(UserAccount account)
        {
            accounts.Add(account);
            SaveAccounts();
        }
        
        public static void readusers()
        {
            UserAccount UAccounts = JsonSerializer.Deserialize<UserAccount>(accountInformation);
        }
    }
}





