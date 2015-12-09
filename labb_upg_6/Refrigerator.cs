using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_upg_6
{
    class Refrigerator
    {
        string brand;
        float temperature;
        bool isOn;
        bool dorIsClosed;
        bool hasFreezer;

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                if (value.Length >= 1 && value.Length <= 20)
                    brand = value;
                else
                    throw new Exception("Error at set Brand");
            }
        }

        public float Temperature
        {
            get
            {
                return temperature;
            }

            set
            {   
                if(value >= -20 && value <= 20)
                temperature = value;
                else
                    throw new Exception("Error att set temperature");
            }
        }

        public bool IsOn
        {
            get
            {
                return isOn;
            }

            set
            {
                isOn = value;
            }
        }

        public bool DorIsClosed
        {
            get
            {
                return dorIsClosed;
            }

            set
            {
                dorIsClosed = value;
            }
        }
        public bool Truthness { get; set; }
        public bool HasFreezer
        {
            get
            {
                return hasFreezer;
            }

            set
            {
                hasFreezer = value;
            }
        }
        public Refrigerator(string brand, float temperature, bool isOn, bool dorIsClosed, bool hasFreezer)
        {
            Brand = brand;
            Temperature = temperature;
            IsOn = isOn;
            DorIsClosed = dorIsClosed;
            HasFreezer = hasFreezer;
        }
        public override string ToString()
        {
            return $"Brand: {Brand} Temperature: {Temperature} IsOn: {IsOn} DorIsClosed: {DorIsClosed} HasFreezer: {HasFreezer}";     
        }
    }
}
