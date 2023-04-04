using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Products
    {

        public int code;
        public string description;
        public decimal price;
        public string Make, Model;

        public int Code { get; set; }

        public string Description { get; set; }

        public decimal Price
        {
            get { return price; }

            set { if (value >= 0) 
                {
                    price = value;
                }
            else price = 0.0m;
            }
        }

        public Products()
        {

        }

        public Products(int inCode, string inDescription, decimal inPrice)
        {
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
        }


    }
}
