using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Cars : Products
    {
        public string transmission;
        public string make;
        public string model;
        public int gears;


        public string Transmission { get; set; }
        public int Gears { get; set; }
        public string type;
        public string Type {get; set; }

        public Cars()
        {

        }

        public Cars(int inCode, string inDescription, decimal inPrice)
        {
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
        }
        public override string ToString()
        {
            string carString = " Make: " +
                make + " Model: " +
                model + " Transmisson: " + transmission
                + " Gears: " + gears;
            return carString;
        }




    }
}
