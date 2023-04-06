using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string path = "C:\\files";
        private void CheckForSave()
        {
            
            //Checks if the user wants to save the file, then either saves or does nothing.
            //Sends nothing, returns nothing
            DialogResult userSave = MessageBox.Show("Save Results to File?",
                "Save File?", MessageBoxButtons.YesNo);
            if (userSave == DialogResult.Yes)
            {
                DialogResult saveResult = sfdReceipt.ShowDialog();

                if (saveResult != DialogResult.Cancel)
                {
                    StreamWriter saveStream = new StreamWriter(sfdReceipt.FileName);

                    for (int i = 0; i <lstCheckout.Items.Count; i++)
                    {
                        
                        saveStream.WriteLine(sfdReceipt);
                    }
                    saveStream.Close();
                    this.Close();
                    MessageBox.Show("File saved successfully to " + path);
                }
                else
                {
                    MessageBox.Show("File saved unsuccessfully to " + path);
                    this.Close();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CheckForSave();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            List<Cars> Cart = new List<Cars>();
            for(int i = 0; i < lstCheckout.Items.Count; i++)
            {
                if (lstCheckout.SelectedItem != null && lstCheckout.SelectedIndex != -1)
                {
                    lstCheckout.Items.Add(Cart[i + 1]);
                }

            }

            if (lstCheckout.SelectedItem != null && lstCheckout.SelectedIndex != -1)
            {
                for (int i = 0; i < lstCheckout.Items.Count; i++)
                {

                    lstCheckout.Items.RemoveAt(i);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
