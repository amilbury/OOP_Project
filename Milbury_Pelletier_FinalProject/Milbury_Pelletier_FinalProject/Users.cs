using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Users
    {

        public int userid;
        public string password;
        public string username;
        public string accessLevel;

        public int UserID { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string AccesLevel { get; set; }


        public Users()
        {

        }

        public Users(int inUserID, 
            string inPassword, string inUserName, string inAccessLevel)
        {
            UserID = inUserID;
            Password = inPassword;
            Username = inUserName;
            AccesLevel = inAccessLevel;
        }


    }
}
