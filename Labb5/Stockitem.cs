using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    public class Stockitem
    {
        internal int id;
        internal string name;
        public static int stockCount = 0;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int StockCount
        {
            get
            {
                return stockCount;
            }

        }
        public Stockitem(int id, string name)
        {
        Id = id;
        Name = name;
        stockCount ++;
        }
        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, StockCount: {StockCount}"; 
        }
    }
}
