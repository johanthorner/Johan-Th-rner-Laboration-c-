using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_upg_6
{
    class MoccaMaster
    {
        bool makingCoffey;
        int cupsOfWater;
        int scoopsOfCoffey;

        public bool MakingCoffey
        {
            get
            {
                return makingCoffey;
            }

            set
            {
                makingCoffey = value;
            }
        }

        public int CupsOfWater
        {
            get
            {
                return cupsOfWater;
            }

            set
            {
                if (value >= 0 && value < 10)
                    cupsOfWater = value;
                else
                    throw new Exception("error: Water");
            }
        }

        public int ScoopsOfCoffey
        {
            get
            {
                return scoopsOfCoffey;
            }

            set
            {
                if (value >= 0 && value < 30)
                    scoopsOfCoffey = value;
                else throw new Exception("error: scoops of coffey");
            }
        }
        public MoccaMaster()
        {
            CupsOfWater = 0;
            ScoopsOfCoffey = 0;
            MakingCoffey = false;
        }
        public MoccaMaster(int cupsOfWater, int scoopsOfCoffey) :this()
        {
            CupsOfWater = cupsOfWater;
            ScoopsOfCoffey = scoopsOfCoffey;
        }
        public MoccaMaster(int cupsOfWater, int scoopsOfCoffey, bool makingCoffey) 
        {
            CupsOfWater = cupsOfWater;
            ScoopsOfCoffey = scoopsOfCoffey;
            MakingCoffey = makingCoffey;
        }
        public override string ToString()
        {
            return $"cups of water: {CupsOfWater} scoops of coffey: {scoopsOfCoffey}, making coffey :{MakingCoffey}";
        }

    }
}
