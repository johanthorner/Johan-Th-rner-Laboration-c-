using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Plate : Stockitem
    {
        string type;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                if (value == "Flat" || value == "Deep")
                    type = value;
                else
                    throw new Exception("Error at value: Plate Type");
            }
            
        }
        public Plate(string type, int id, string name) : base(id, name)
        {
            Type = type;
            Id = id;
            Name = name;
          
        }
        public override string ToString()
        {
            return $"{ base.ToString()} Typ: {Type}.";
        }
    }
}
