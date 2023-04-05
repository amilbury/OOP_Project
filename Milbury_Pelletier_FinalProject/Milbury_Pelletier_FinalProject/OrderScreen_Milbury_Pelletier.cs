﻿using System;
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
        //setting up path varialble
        //private const string Path = "C:\\files";

        //creating new array of products
        Products[] productsArray;
        private void OrderScreen_Milbury_Pelletier_Load(object sender, EventArgs e)
        {
            if(this.Tag != null)
            {
                Users users = (Users)this.Tag;
                if(users.AccessLevel == "Admin")
                {
                    grpAdminControls.Visible = true;
                }
            }
            cboCarType.Items.Add("Choose a car type:");
            cboCarType.SelectedIndex = 0;
            cboCarType.Items.Add("Luxury Cars");
            cboCarType.Items.Add("Sports Cars");

            
        }

        private void cboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCarType.SelectedIndex == 1)
            {
                FillList(@"..\..\Luxury.xml");
            }
            else if(cboCarType.SelectedIndex == 2)
            {
                FillList(@"..\..\Sports.xml");
            }
        }
        
        /*
         * Name: FillList
         * Returns: Void
         * Sent: A string to act as the path
         * Date: April 5th, 2023
         * Author: Aaron Milbury
         */
        private void FillList(string path)
        {
            lstProducts.Items.Clear();
            try
            {
                Random rand = new Random();
                List<Cars> products = new List<Cars>();
                products = ProductDB.GetProducts(path);
                foreach (Cars car in products)
                {
                    car.Stock = rand.Next(-10, 100);
                    if(car.Type == "Sports")
                    {
                    SportsCar sportsCar = Cars.CloneSport(car);
                    sportsCar.horsePower = rand.Next(300, 700);
                        lstProducts.Items.Add(sportsCar.ToString());
                    }
                    else if (car.Type == "Luxury")
                    {
                        LuxuryCar luxuryCar = Cars.CloneLuxury(car);
                        switch (luxuryCar.CompareTo(luxuryCar)) //use a switch
                        {
                            case 1: luxuryCar.Tier = "High"; break;
                            case -1: luxuryCar.Tier = "Low"; break;
                            case 0: luxuryCar.Tier = "Mid"; break;
                        }
                        lstProducts.Items.Add(luxuryCar.ToString());
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
            LoginScreen_Milbury_Pelletier loginScreen = new LoginScreen_Milbury_Pelletier();
            
        }
    }
}
