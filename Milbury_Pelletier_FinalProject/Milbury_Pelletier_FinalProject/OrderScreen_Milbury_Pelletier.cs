using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using ProductMaintenance;

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
                FillLists(@"..\..\Luxury.xml");
                FillLists(@"..\..\Sports.xml");
            
            if (this.Tag != null)
            {
                Users users = (Users)this.Tag;
                if(users.AccessLevel == "Admin")
                {
                    grpAdminControls.Visible = true;
                }
            }
            //Add controls to the combo box
            cboCarType.Items.Add("Choose a car type:");
            cboCarType.SelectedIndex = 0;
            cboCarType.Items.Add("Luxury Cars");
            cboCarType.Items.Add("Sports Cars");

            
        }

        //If the selected index is 1, fill the list with luxury cars, if selected index is 2,
        //fill it with sports cars
        private void cboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCarType.SelectedIndex == 1)
            {
                lstProducts.Items.Clear();
                foreach (LuxuryCar item in luxuryCars)
                {
                    if (item.Stock == 0)
                    {

                    }
                    else
                    {

                        lstProducts.Items.Add(item.ToString());
                    }
                }
            }
            else if (cboCarType.SelectedIndex == 2)
            {
                lstProducts.Items.Clear();
                foreach (SportsCar item in sportsCars)
                {
                    if (item.Stock == 0)
                    {

                    }
                    else
                    {

                        lstProducts.Items.Add(item.ToString());
                    }
                }
            }
        }
        
        /*
         * Name: FillList
         * Returns: Void
         * Sent: A string to act as the path
         * Date: April 5th, 2023
         * Author: Aaron Milbury
         */

        List<LuxuryCar> luxuryCars = new List<LuxuryCar>();
        List<SportsCar> sportsCars = new List<SportsCar>();
        private void FillLists(string path)
        {

            try
            {
                Random rand = new Random();
                List<Cars> products = new List<Cars>();
                products = ProductDB.GetProducts(path);
                foreach (Cars car in products)
                {

                    //If the car is a sports car, give it a horsepower and add it to the list
                    //of sports cars
                    if(car.Type == "Sports")
                    {
                    SportsCar sportsCar = Cars.CloneSport(car);
                    sportsCar.horsePower = rand.Next(300, 700);
                    sportsCars.Add(sportsCar);
                    }
                    //If the car is a luxury car, give it a tier based on its price
                    //and add it to the list box
                    else if (car.Type == "Luxury")
                    {
                        LuxuryCar luxuryCar = Cars.CloneLuxury(car);
                        //switch to using Icompareable to
                        //compare different prices of cars to eachother to determine the tier
                        switch (luxuryCar.CompareTo(luxuryCar))
                        {
                            case 1: luxuryCar.Tier = "High"; break;
                            case -1: luxuryCar.Tier = "Low"; break;
                            case 0: luxuryCar.Tier = "Mid"; break;
                        }
                        luxuryCars.Add(luxuryCar);
                    }
                    else
                    {
                        lstProducts.Items.Add(car.ToString());
                    }
                }
           }
            catch
            {
                MessageBox.Show("Error: Path is incorrect", "Error");
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add the cars on the selected index to the cart
        List<Cars> Cart = new List<Cars>();
        private void btnCart_Click(object sender, EventArgs e)
        {
            if(lstProducts.Tag != null)
            {
                Cart.Add((Cars)lstProducts.Tag);
            }

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Compare the items in the list and make the tag of the list = the selected object
            for(int i = 0; i < lstProducts.Items.Count; i++)
            {

                if (sportsCars[i].ToString() == lstProducts.Items[i].ToString() || 
                    luxuryCars[i].ToString() == lstProducts.Items[i].ToString())
                {
                    lstProducts.Tag = sportsCars[i];
                    break;
                }
            }


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Create a checkout form and close the orders form
            CheckoutForm_Milbury_Pelletier checkoutForm = new CheckoutForm_Milbury_Pelletier();
            checkoutForm.ShowDialog();

            for (int i = 0; i < Cart.Count; i++)
            {
                checkoutForm.Tag = Cart;
            }
            this.Close();
        }
    }
}
