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
    public partial class newCar_Milbury_Pelletier : Form
    {
        public newCar_Milbury_Pelletier()
        {
            InitializeComponent();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "" && txtMake.Text != "" && txtModel.Text != "" && 
                (txtType.Text == "Sports" || txtType.Text == "Luxury"))
            {
                
                    Cars car = new Cars(Convert.ToDecimal(txtPrice), txtMake.Text, txtModel.Text, txtType.Text, Convert.ToInt32(nudQuantity.Value));


                Tag = car;
                this.Close();
            }
        }
    }
}
