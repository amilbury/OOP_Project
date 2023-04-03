using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Customer cathy = new Customer("cathy", "cathy", "Customer");
            Admin admin = new Admin("admin", "admin", "Admin");
            userList.Add(cathy);
            userList.Add(admin);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && txtPSW.Text != "")
            {
                
            }
        }
    }
}
