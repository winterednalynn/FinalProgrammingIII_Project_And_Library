using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class UserAccount
    {
            
            public enum Role { ProfessionalArtist, BeautyStudent }
            string _name;
            string _userName;
            string _password;
            Role _role;

 

            public UserAccount()
            {

            }
            public UserAccount(string name, string userName, string password, Role role)
            {
                _name = name;
                _userName = userName;
                _password = password;
                _role = role;
            }

        public string Name { get => _name; set => _name = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public Role Role1 { get => _role; set => _role = value; }

        






        
    }
}
