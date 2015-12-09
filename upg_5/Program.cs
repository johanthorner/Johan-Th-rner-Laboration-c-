using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stove myStove = new Stove();
            myStove.SetPowerOn(true);
            myStove.SetNumberOfHotplates(4);
            myStove.SetStoveType("Electrolux");

            Bread myBread = new Bread();
            myBread.SetCupsOfWater(2);
            myBread.SetCupsOfFlour(6);
            myBread.SetJeast(true);

            myStove.SetBaking(myBread);
            
            Kitchen myKitchen = new Kitchen();
            myKitchen.SetStove(myStove);

            Console.WriteLine(myKitchen.GetKitchenInfo());
        }
    }
}
