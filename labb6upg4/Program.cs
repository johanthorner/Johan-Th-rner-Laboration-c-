using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb6upg4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa en klass kallad MyDoubleType som endast innehåller ett double-fält,
            kallat doubleValue. Exponera fältet publikt mha en propery.,
            och skapa även en konstruktor som initierar fältet.
            Klassen ska även överlagra ToString() som ska returnera värdet på fältet
            som en string.

            Överlagra operatorerna +, -, /, *, ==, !=, <, >, <= och >=. 
            De aritmetiska operatorerna ska finnas i två varianter;
            en där andra operanden är en double,
            och en där operanden andra operanden är en MyDoubleType.
            De jämförande operatorerna ska finnas i en variant som
            jämför två instanser av MyDoubleType.
            Nedan visas ett programkörningsexempel:*/
            MyDoubleType myDoubleType = new MyDoubleType(5);
            MyDoubleType myDoubleType1 = new MyDoubleType(5);

            myDoubleType += 5;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType += myDoubleType;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType -= 5;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType -= myDoubleType;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType += 15;

            myDoubleType /= 3;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType *= 3;
            Console.WriteLine(myDoubleType.DoubleValue);

            myDoubleType *= myDoubleType;
            Console.WriteLine(myDoubleType.DoubleValue);

            

            myDoubleType -= 200;
            myDoubleType1 += 110;
            Console.WriteLine($"myDoubleType: {myDoubleType.DoubleValue} myDoubleType1: {myDoubleType1.DoubleValue}");
       
            Console.WriteLine($"{myDoubleType} == {myDoubleType1} : {myDoubleType == myDoubleType1}");

            Console.WriteLine($"{myDoubleType} != {myDoubleType1} : {myDoubleType != myDoubleType1}");

            Console.WriteLine($"{myDoubleType} < {myDoubleType1} : {myDoubleType < myDoubleType1}");

            Console.WriteLine($"{myDoubleType} > {myDoubleType1} : {myDoubleType > myDoubleType1}");

            myDoubleType1 -=90;

            Console.WriteLine($"{myDoubleType} >= {myDoubleType1} : {myDoubleType >= myDoubleType1}");

            myDoubleType1 -= 10;

            Console.WriteLine($"{myDoubleType} <= {myDoubleType1} : {myDoubleType <= myDoubleType1}");
        }
    }
}
