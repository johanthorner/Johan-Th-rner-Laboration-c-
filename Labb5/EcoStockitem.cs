using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
     class EcoStockitem : Stockitem
    {
       internal string markning;

        public string Markning
        {
            get
            {
                return markning;
            }

            set
            {

                if (value == "EG" || value == "Krav")
                    markning = value;
                else
                    throw new Exception("Error at markning");
            }
            
        }
        public EcoStockitem(string markning, int id, string name) : base(id, name)
        {
            Markning = markning;
            Id = id;
            Name = name;
            

        }
        public override string ToString()
        {
            return $"{base.ToString()} Märkning: {Markning}"; 
        }
    }
}
