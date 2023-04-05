using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milbury_Pelletier_FinalProject
{
    public sealed class LuxuryCar : Cars, IComparable<LuxuryCar>
    {
        public string tier;
        public string Tier { get; set; }

        public int CompareTo(LuxuryCar other)
        {
            int compared;

            if(other.Price > 300000)
            {
                compared = 1;
            }
            else if(other.Price > 200000)
            {
                compared = 0;
            }
            else
            {
                compared = -1;
            }
            return compared;
        }

        public override string ToString()
        {
            string luxoryCar = base.ToString() + " Tier: " + Tier;
            return luxoryCar;
        }

    }
}
