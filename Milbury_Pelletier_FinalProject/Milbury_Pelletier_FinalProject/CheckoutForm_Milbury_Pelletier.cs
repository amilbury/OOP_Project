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
        List<Cars> checkoutCart = new List<Cars>();
        public string Data = this.Tag;
        private void CheckoutForm_Milbury_Pelletier_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < checkoutCart.Count; i++)
            {

            }
            checkoutCart.Add(Data);
        }
    }
}
