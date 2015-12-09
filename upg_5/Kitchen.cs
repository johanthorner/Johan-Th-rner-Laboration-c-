using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_5
{
    class Kitchen
    {
        Stove stove;

        public void SetStove(Stove stove)
        {

            this.stove = stove;
        }
        public string GetKitchenInfo()
        {
            string kitchenString = $"Kitchen: {stove.GetStoveInfo()}";
            return kitchenString;
        }
    }
}
