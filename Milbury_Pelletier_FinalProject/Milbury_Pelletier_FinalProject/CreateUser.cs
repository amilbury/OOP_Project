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
    public partial class CreateUser : Form
    {
        public static CreateUser userInstance;
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btncreateUser_Click(object sender, EventArgs e)
        {

            Form createUserInstance = new Form();
            createUserInstance = this;

        }
    }
}
