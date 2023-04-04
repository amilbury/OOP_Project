using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using Milbury_Pelletier_FinalProject;

namespace ProductMaintenance
{
    public static class ProductDB
    {
        private const string Path = @"..\..\Cars.xml";

        public static List<Cars> GetProducts()
        {
            // create the list
            List<Cars> products = new List<Cars>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Product"))
            {
                // create one Product object for each Product node
                do
                {
                    Cars product = new Cars();
                    xmlIn.ReadStartElement("Product");
                    product.Code = 
                        Convert.ToInt32(xmlIn.ReadElementContentAsString());
                    product.Description =
                        xmlIn.ReadElementContentAsString();
                    product.Price =
                        xmlIn.ReadElementContentAsDecimal();
                    product.Transmission = xmlIn.ReadElementContentAsString();
                    product.Type = xmlIn.ReadElementContentAsString();
                    products.Add(product);
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return products;
        }

        public static void SaveProducts(List<Cars> cars)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Cars");

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
