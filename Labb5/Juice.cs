﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            
           
            Type = type;
        }

        public Juice(Juice juice, string markning, int id, string name, string type) : this(markning, id,  name, type)
        {
            
            //Markning = juice.markning;
        }
        public override string ToString() 
        {
            return $"{base.ToString()} Typ: {Type}";
        }
    }
}
