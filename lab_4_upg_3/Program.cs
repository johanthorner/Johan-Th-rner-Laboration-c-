using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_upg_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Utgå från klassen i föregående uppgift och utöka den med två konstruktors som initierar Radion.
            Den ena konstruktorn ska vara default-konstruktorn, och den andra ska sätta volym och frekvens.
            I båda fallen ska on/off sättas till off.
            Sätt vettiga förval på alla fält i default-konstruktorn som du sedan anropar från den andra konstruktorn. 
            Konstruktorn som tar argument ska använda dina properties för att sätta fälten, 
            dvs manipulera inte fälten direkt från konstruktorn. 
            Detta gör att valideringen endast behöver göras på ett ställe. 
            Hela detta upplägg gör att din klass alltid kommer innehålla giltig information.*/

            Radio radio = new Radio(45, 90.0);
            Console.WriteLine(radio);
            Console.ReadLine();
        }
    }
}
