using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_upg_1
{
    class Car
    {
        string brand;
        int numberOfGears;
        string color;
        string type;

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public int NumberOfGears
        {
            get
            {
                return numberOfGears;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    numberOfGears = value;
                }
                else throw new Exception("Error: number of gears");
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                if (value == "kupe" || value == "kombi")
                    type = value;
                else
                    throw new Exception("error: type");
            }
        }
        public Car(string brand, int numberOfGears, string color, string type)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Color = color;
            Type = type;
        }
        public Car(string type)
        {
            Brand = "smartcar";
            NumberOfGears = 3;
            Color = "green";
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, NumberOfGears: {NumberOfGears}, Color: {Color}, Type: {Type}.";
        }
    }
}
