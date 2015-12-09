using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_upg_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa några Radio - objekt där du använder object initializers.
            Radio newRadio = new Radio { PowerOn = true, Frequency = 123.2, Volume = 23};
            Radio newRadio2 = new Radio { PowerOn = false, Volume = 1 };
            Radio newRadio3 = new Radio { PowerOn = true};
            Console.WriteLine(newRadio);
            Console.WriteLine(newRadio2);
            Console.WriteLine(newRadio3);
        }
    }
}
