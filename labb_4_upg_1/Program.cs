using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_upg_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Uppgift 1
            Skapa en klass kallad Bil, som har fälten marke, antalVaxlar, farg och typ.
            Skapa properties för fälten. 
            I set-delen av propertien som manipulerar fältet typ ska du se till att endast värdena "kupe" eller "kombi" kan användas,
            i andra fall ska fältet inte ändras. 
            Skapa instanser och prova att först sätta typ till "kombi", därefter till "suv", och läs ut vad typ har för värde.*/

            Car myCar = new Car("volvo",4,"green","kombi" );
            Console.WriteLine(myCar);
        }
    }
}
