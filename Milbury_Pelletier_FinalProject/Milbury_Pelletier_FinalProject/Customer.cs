using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Customer : Users
    {
        public Customer() { }

        public Customer(int inUserID, string inUsername, string inPassword, string inAccessLevel)
        {
            UserID = inUserID;
            Username = inUsername;
            Password = inPassword;
            AccessLevel = inAccessLevel;    
        }


    }
}
