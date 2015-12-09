using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_5
{
    class Stove
    {
        string stoveType;
        int numberOfHotplates;
        bool powerOn;
        Bread baking;
        
        public void SetStoveType(string stoveType)
        {
            this.stoveType = stoveType;
        }
        public void SetBaking(Bread baking)
        {
            this.baking = baking;
        }
        public void SetNumberOfHotplates(int numberOfHotplates)
        {
            this.numberOfHotplates = numberOfHotplates;
        }
        public int GetNumberOfHotplates()
        {
            return numberOfHotplates;
        }
        public void SetPowerOn(bool powerOn)
        {
            this.powerOn = powerOn;
        }
        public bool GetPowerOn()
        {
            return powerOn;
        }
        public string GetStoveInfo()
        {
                      
            return $"Stove: stove type: {stoveType}, Hotplates: {numberOfHotplates}, Is power on: {powerOn}. Baking a bread With Recepie:{baking.BreadInfo()}";
           
        }
    }
}
