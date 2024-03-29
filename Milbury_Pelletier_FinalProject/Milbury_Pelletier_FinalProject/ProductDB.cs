using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using Milbury_Pelletier_FinalProject;
using System.Net.Http.Headers;

namespace ProductMaintenance
{
    public static class ProductDB
    {
        //private const string path = @"..\..\Cars.xml";

        public static List<Cars> GetProducts(string path)
        {
            // create the list
            List<Cars> products = new List<Cars>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Product"))
            {
                // create one Product object for each Product node
                do
                {

                    xmlIn.ReadStartElement("Product");
                    decimal price =
                        xmlIn.ReadElementContentAsDecimal();
                    string make = xmlIn.ReadElementContentAsString();
                    string model = xmlIn.ReadElementContentAsString();
                    string type = xmlIn.ReadElementContentAsString();
                    int stock = xmlIn.ReadElementContentAsInt();
                    Cars product = new Cars(price, make, model, type, stock);
                    products.Add(product);
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return products;
        }

        public static void SaveProducts(List<Cars> cars, string path)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Product");

            // write each product object to the xml file
            foreach (Cars product in cars)
            {
                xmlOut.WriteStartElement("Product");
                xmlOut.WriteElementString("Code: ",
                    product.Code.ToString());
                xmlOut.WriteElementString("Description: ",
                    product.Description);
                xmlOut.WriteElementString("Make: ",
                    product.Make);
                xmlOut.WriteElementString("Model: ",
                    product.Model);
                xmlOut.WriteElementString("Transmission: ",
                    product.Transmission);
                xmlOut.WriteElementString("Gears: ",
                    product.Gears.ToString());
                xmlOut.WriteElementString("Price: ",
                    Convert.ToString(product.Price));
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
