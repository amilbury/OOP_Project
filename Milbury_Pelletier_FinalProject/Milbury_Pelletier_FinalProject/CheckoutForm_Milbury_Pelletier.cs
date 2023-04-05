using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milbury_Pelletier_FinalProject
{
    public partial class CheckoutForm_Milbury_Pelletier : Form
    {
        public CheckoutForm_Milbury_Pelletier()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Milbury_Pelletier_Load(object sender, EventArgs e)
        {
            List<Cars> cars = (List<Cars>)this.Tag;
            for (int i = 0; i < cars.Count; i++)
            {
                lstCheckout.Items.Add(cars[i]);
            }
        }
    }
}
