using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Stock
    {
        Stockitem[] stockItems = new Stockitem[10];
        int counter = 0;

        public Stockitem this[int index]
        {
            get
            {
                if (index >= 0 && index < stockItems.Length)//kontroll på att man hämtar värden innom arrayen gränser
                    return stockItems[index];
                throw new Exception("out of boundary");/* return the specified index here */
            }
            set {
                if (index >= 0 && index < stockItems.Length)
                    stockItems[index] = value;
                else
                    throw new Exception("out of boundary");/* set the specified index to value here */
            }
        }
        public void AddItem(Stockitem item)
        {
            if (counter < stockItems.Length)//all tillgång till klassen sker härigenom.
            {
                stockItems[counter] = item;
                counter++;

            }else
            {
                throw new Exception("Error det är fullt");
            }
        }
        public void PrintItems()
        {
            for (int i = 0; i <= counter; i++)
            {
                Console.WriteLine(stockItems[i]);

                var item = stockItems[i];
                if (item is EcoStockitem)
                {
                    Console.WriteLine(" Ekologisk");
                }
                
            }
        }
    }
}
