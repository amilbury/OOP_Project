using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milbury_Pelletier_FinalProject
{
    public sealed class LuxuryCar : Cars
    {
        public string tier;
        public string Tier { get; set; }



        public override string ToString()
        {
            string luxoryCar = base.ToString() + "Tier: " + Tier;
            return luxoryCar;
        }

    }
}
