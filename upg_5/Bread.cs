using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_5
{
    class Bread
    {
        int cupsOfWater;
        int cupsOfFlour;
        bool jeast;
        public void SetCupsOfWater(int cupsOfWater)
        {
            this.cupsOfWater = cupsOfWater;
        }
        public void SetCupsOfFlour(int cupsOfFlour)
        {
            this.cupsOfFlour = cupsOfFlour;
        }
        public void SetJeast(bool jeast)
        {
            this.jeast = jeast;
        }
        public string BreadInfo()
        {
            string jeastString = "";
            if (jeast) {jeastString = "Yes"; }
            else {jeastString = "No"; }
            return $"Cups of Flour: {cupsOfFlour} Cups of water {cupsOfWater} jeast: {jeastString}";
        }
            
    }

}
