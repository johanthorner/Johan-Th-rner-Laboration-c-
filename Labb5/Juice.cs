using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Juice : EcoStockitem
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
                if(value == "Apple" || value == "Orange")
                type = value;
                else
                throw new Exception("Error at juice type.");
            }
        }
        public Juice(string markning, int id, string name, string type ) : base(markning,id,name)
        {
            
            Markning = markning;
            Id = id;
            Name = name;
            Type = type;
        }
        public override string ToString() 
        {
            return $"{base.ToString()} Typ: {Type}";
        }
    }
}
