using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_upg_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Utgå från Radio-klassen, och utöka denna så att den håller reda på hur många instanser som skapats.
            Skapa först ett statiskt fält kallas instanceCount, som du exponerar mha en read-only property.
            Initiera fältet till 0 i en statisk konstruktor, och räkna upp detta fält i default-konstruktorn. 
            Eftersom denna konstruktor anropas från den andra konstruktorn så kommer alltid fältet räknas upp oavsett vilken constructor som anropas.*/

            Radio newRadio = new Radio();
            Radio newRadio2 = new Radio();
            Console.WriteLine(Radio.InstanceCount);
            
        }
    }
}
