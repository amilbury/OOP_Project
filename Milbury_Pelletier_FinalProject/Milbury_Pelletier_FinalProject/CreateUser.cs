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


        private void btncreateUser_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtUsername.Text != "")
            {
                Customer newCustomer = new Customer(txtUsername.Text, txtPassword.Text, "Customer");
                Tag = newCustomer;
                this.Close();
            }
        }

        private void btncancelProcess_Click(object sender, EventArgs e)
        {
            this.Close();
            Tag = null;
        }
    }
}
