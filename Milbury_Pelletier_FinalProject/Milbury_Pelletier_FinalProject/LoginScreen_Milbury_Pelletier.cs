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
        private string OpenForm()
        {
            //This function will open the second form and return the value sent back from it
            CreateUser createUser = new CreateUser();

            createUser.ShowDialog();
            createUser.newCustomer.Username = this.txtUsername.Text;
            createUser.newCustomer.Password = this.txtPassword.Text;
            createUser.newCustomer.AccessLevel = "Customer";
            return (int)createUser.Tag;
        }


    }
}
