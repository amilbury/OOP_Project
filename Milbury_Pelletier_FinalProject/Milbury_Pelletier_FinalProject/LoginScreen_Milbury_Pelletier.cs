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
        
        }

        //open form function 
        private int OpenForm()
        {
            //This function will open the second form and return the value sent back from it
            CreateUser createUser = new CreateUser();

            createUser.ShowDialog();

            return (int)createUser.Tag;
        }
    }
}
