using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            stockExchange();

            //piMethod();

            //printPerson();

        }

        private static void printPerson()
        {
            //inte återanvända variabel
            string name = "Jonas";
            string town = "Helsingborg";
            string part = "Stattena";
            string at = "Hemköp";

            string printString = String.Format($"Han Heter {name} och bor i {town} på {part} vid {at}.");
            Console.WriteLine(printString);

           
        }

        private static void piMethod()
        {   
            //konstant
            //Talet π är cirka 3.141592654 men kan avrundas till 3.14 och kan lite grovt skrivas som 3
             const double pi = 3.141592654;

            String printString = String.Format("Talet π är cirka {0} men kan avrundas till {1} och kan lite grovt skrivas som {2}", pi, Math.Round(pi, 2), Math.Round(pi));
            Console.WriteLine(printString);
        }

        private static void stockExchange()
        {
            float dowJones = 12.4f; //rätt värde
            float nasdaq = 3.4f;
            float stockholm = 2.4f;
            float milano = 1.3f;
            float paris = -0.3f;

            float[] stockEchange = new float[5] { dowJones, nasdaq, stockholm, milano, paris };
            string printString = String.Format($"Dow Jones: {stockEchange[0]} procent, Nasdaq: {stockEchange[1]} procent, Stockholm: {stockEchange[2]} procent, Milano: {stockEchange[3]} procent, Paris: {stockEchange[4]}");
            Console.WriteLine(printString);

            //for (int i = 0; i < stockEchange.Length; i++)
            //{
            //    stockEchange[i] = stockEchange[i] * 2;
            //}


            stockEchange[0] = stockEchange[0] - 4;

            printString = String.Format($"Dow Jones: {stockEchange[0]} procent, Nasdaq: {stockEchange[1]} procent, Stockholm: {stockEchange[2]} procent, Milano: {stockEchange[3]} procent, Paris: {stockEchange[4]}");
            Console.WriteLine(printString);
        }
    }
}
