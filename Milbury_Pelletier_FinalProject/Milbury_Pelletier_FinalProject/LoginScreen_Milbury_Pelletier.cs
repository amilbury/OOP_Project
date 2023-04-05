using Classy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milbury_Pelletier_FinalProject
{
    public partial class LoginScreen_Milbury_Pelletier : Form
    {
        public LoginScreen_Milbury_Pelletier()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        //open form function 
        private Customer OpenForm()
        {
            //This function will open the second form and return the value sent back from it
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
            if (createUser.Tag == null)
            {

            }
            else
            {
                Customer tagCust = (Customer)createUser.Tag;
                userList.Add(tagCust);
                return tagCust;
            }
            return null;

        }
        public List<Users> userList = new List<Users>();
        private void LoginScreen_Milbury_Pelletier_Load(object sender, EventArgs e)
        {
            //read different users from the text file and put them into the user list
            Customer cathy = new Customer("cathy", "cathy", "Customer");
            Admin admin = new Admin("admin", "admin", "Admin");
            userList.Add(cathy);
            userList.Add(admin);
            string line;
            string line2;
            string line3;

            StreamReader nameFile = new StreamReader(@"..\..\Users.txt");

            for (int i = 2; i == 7; i++)
            {
                line = nameFile.ReadLine();
                line2 = nameFile.ReadLine();
                line3 = nameFile.ReadLine();
                userList.Add(new Customer(line, line2, line3));
            }
            //close file
            nameFile.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtID) && Validator.IsPresent(txtPSW))
            {
                for(int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].Username == txtID.Text && userList[i].Password == txtPSW.Text)
                    {
                        this.Tag = userList[i];
                        this.Hide();
                        OrderScreen_Milbury_Pelletier orderScreen = new OrderScreen_Milbury_Pelletier();
                        orderScreen.Tag = userList[i];
                        orderScreen.ShowDialog();
                        orderScreen = null;
                        this.Show();
                    }
                }
            }

            
        }
    }
}
