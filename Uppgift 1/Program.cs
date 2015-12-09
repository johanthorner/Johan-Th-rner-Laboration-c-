using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main()
        {
            int nummer1 = 1;
            int nummer2 = 2;
            int nummer3 = 3;
            Console.WriteLine("Nummer ett: {0} ,nummer två:{1}, nummer tre: {2} ", nummer1, nummer2, nummer3);      //obs varibleran räknas från 0
            Console.WriteLine($"Nummer ett:{nummer1} nummer två: {nummer2} nummer tre {nummer3}");                  //nytt i c#6  man måste använda $
            Console.WriteLine("skriv ut siffra i valuta ...{0:C}", nummer1);                                        //:C blir till kr i utskrift
            Console.WriteLine("{0,100}{1,50}","första...","andra...");                                              //den första siffran bestämmet villken av strängarna, andra siffran var den ska placeras.

                                
            
            Console.ReadLine();

        }
        
    }
}