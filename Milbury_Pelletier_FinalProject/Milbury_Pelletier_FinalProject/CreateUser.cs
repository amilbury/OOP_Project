using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milbury_Pelletier_FinalProject
{
    public partial class CreateUser : Form
    {
        public static CreateUser userInstance;
        public CreateUser()
        {
            InitializeComponent();
        }
        //create new customer object and fill with values from new form, then add to list 
        public Customer newCustomer = new Customer();

        private void btncreateUser_Click(object sender, EventArgs e)
        {
            int userTag = Convert.ToInt32(txtUsername.Text);
            string passTag = txtPassword.Text;
            newCustomer.UserID = userTag;
            newCustomer.Password = passTag;
            this.Close();
        }

        private void btncancelProcess_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
