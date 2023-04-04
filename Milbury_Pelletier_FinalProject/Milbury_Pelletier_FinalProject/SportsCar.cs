using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class SportsCar : Cars
    {
        public int horsePower;

        public int HorsePower { get; set; }

        public override string ToString()
        {
            string sportsCar = base.ToString() + "Horse Power:  " + horsePower.ToString();
            return sportsCar;
        }
    }
}
