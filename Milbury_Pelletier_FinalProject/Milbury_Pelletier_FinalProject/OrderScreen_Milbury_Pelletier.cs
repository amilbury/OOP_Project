﻿using System;
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
    public partial class OrderScreen_Milbury_Pelletier : Form
    {
        public OrderScreen_Milbury_Pelletier()
        {
            InitializeComponent();
        }

        private void OrderScreen_Milbury_Pelletier_Load(object sender, EventArgs e)
        {
            cboCarType.Items.Add("Choose a car type:");
            cboCarType.SelectedIndex = 0;
            cboCarType.Items.Add("Luxury Cars");
            cboCarType.Items.Add("Sports Cars");
        }

        private void cboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCarType.SelectedIndex == 1)
            {

            }
            else if(cboCarType.SelectedIndex == 2)
            {

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen_Milbury_Pelletier loginScreen = new LoginScreen_Milbury_Pelletier();
            
        }
    }
}