using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Admin : Users
    {
        public Admin()
        {

        }

        public Admin(string inUsername, string inPassword, string inAccessLevel)
        {
            Username = inUsername;
            Password = inPassword;
            AccessLevel = inAccessLevel;
        }

    }
}
