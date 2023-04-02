using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public abstract class Cars : Products
    {
        public string transmission;
        public string make;
        public string model;
        public int gears;

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
