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

namespace Milbury_Pelletier_FinalProject
{
    public partial class OrderScreen_Milbury_Pelletier : Form
    {
        public OrderScreen_Milbury_Pelletier()
        {
            InitializeComponent();
        }
        //setting up path varialble
        private const string Path = "C:\\files";

        //creating new array of products
        Products[] productsArray;
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

<<<<<<< Updated upstream
        public List<Products> GrabProducts() {
            // create the array
            List<Products> products = new List<Products>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Products"))
            {
                // create one Product object for each Product node
                do
                {
                    Products product = new Products();
                    xmlIn.ReadStartElement("Products");
                    product.Price = 
                        xmlIn.ReadElementContentAsDecimal();
                    product.Make =
                        xmlIn.ReadElementContentAsString();
                    product.Model =
                        xmlIn.ReadElementContentAsString();
                    products.Add(product);
                }
                while (xmlIn.ReadToNextSibling("Products"));
            }

// close the XmlReader object
            xmlIn.Close();

=======
        public Products GetProducts()
        {
            Products products = new Products();

>>>>>>> Stashed changes
            return products;
        }
    }
}
