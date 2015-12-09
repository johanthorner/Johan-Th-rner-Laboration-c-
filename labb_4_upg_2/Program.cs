using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_upg_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I denna uppgift får du själv funder lite på hur klassen ska implementeras.
              Skapa en klass i en ny fil som du lägger till projektet.
              Kalla klassen Radio. Denna klass ska modellera en riktig radio, där kontroller finns för volym, av/på, samt frekvensinställning.
              Fundera på vilka datatyper som ska användas för respektive fält.
              Validera indata till både volym och frekvens för att se till att dessa håller sig inom rimliga gränser.*/

            Radio myRadio = new Radio();
            Console.WriteLine(myRadio);
        }
    }
}
