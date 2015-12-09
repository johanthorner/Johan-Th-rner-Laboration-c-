using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_upg_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoccaMaster();
            Refrigerator myFridge = new Refrigerator("electrolux", -2, true, true, false);
            Console.WriteLine(myFridge);
        }

        private static void MoccaMaster()
        {
            MoccaMaster johansMoccaMaster = new MoccaMaster();
            MoccaMaster johansMoccaMaster2 = new MoccaMaster(5, 6);
            MoccaMaster johansMoccaMaster3 = new MoccaMaster(7, 8, true);
            Console.WriteLine(johansMoccaMaster);
            Console.WriteLine(johansMoccaMaster2);
            Console.WriteLine(johansMoccaMaster3);
        }
    }
}
