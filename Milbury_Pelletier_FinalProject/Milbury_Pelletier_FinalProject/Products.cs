using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public abstract class Products
    {

        public int code;
        public string description;
        public decimal price;

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

    }
}
