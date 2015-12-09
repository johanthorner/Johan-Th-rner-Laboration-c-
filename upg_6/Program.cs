using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upg_2;
using upg_3;
namespace upg_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många cirklar vill du skapa?");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Skapar {userInput} cirklar");

            Circle[] circelArray = new Circle[userInput];
            
            Random randomNumber = new Random();

            for (int i = 0; i < circelArray.Length; i++)
            {
                Circle newCircel = new Circle();

                newCircel.SetDiameter(randomNumber.Next(15));
                circelArray[i] = newCircel;

            }
            printArrayNaturall(circelArray);

            printArraySevenToSeventeen(circelArray);

            twoToTwentyTwoCounter(circelArray);

            /*Fråga användaren hur många Cirkels han vill skapa. Exempelvis 1000st unika Circles med rimliga slumpade värden. Genomför sedan följande:
            Skriv ut dem som har en diameter som är mellan 7 och 17
            Räkna hur många som har en omkrets som är 2 till 22.
            De Cirklar som befinner sig kortare sträcka från origo än 12. Ändra deras diameter så att cirkeln kommer att träffa origo om den ritas ut.
            Skapa dubbletter av cirklarna där de nya cirklarna har exakt motsatt koordianter mot ursprungs-cirklarna.
            Skapa 4st Cirklar per Cirkel som valts. Gör dem maximalt stora och placera dem korrekt i Ursprungscirklarna.
            Fråga användaren efter en area och skriv ut de Cirklar som har en Area som är större än den angivna.
            Fråga användren efter ett tal och flytta alla cirklarna så mycket som angetts i X-led.
            Fråga användren efter ett tal och flytta alla cirklarna så mycket som angetts i Y-led.
            Gör en meny så att man kan välja vilken av ovanstående operationer som ska genomföras hur många gånger som helst. Lägg till menyvalet avsluta.
            Ändra så att användaren skriver in siffror i stället för att ha hårdkodade värden som 7, 17, 2... på punkt 1 i denna uppgiften. */
        }

        private static void twoToTwentyTwoCounter(Circle[] circelArray)
        {
            int counterBetweenTwoToTwentytwo = 0;
            for (int i = 0; i < circelArray.Length; i++)
            {
                if (circelArray[i].GetCircumference() > 2 && circelArray[i].GetCircumference() < 22)
                {
                    counterBetweenTwoToTwentytwo++;
                }
            }
            Console.WriteLine("-----");
            Console.WriteLine($"Antal cirklar som har en omkrets mellan 2 till 22: {counterBetweenTwoToTwentytwo}");
        }

        private static void printArraySevenToSeventeen(Circle[] circelArray)
        {
            Console.WriteLine("-----");
            Console.WriteLine("omkrets mellan 7 och 17: ");

            for (int i = 0; i < circelArray.Length; i++)
            {
                if (circelArray[i].GetCircumference() > 7 && circelArray[i].GetCircumference() < 17)
                {
                    Console.WriteLine(circelArray[i].GetCircumference());
                }
            }
        }

        private static void printArrayNaturall(Circle[] circelArray)
        {
            for (int i = 0; i < circelArray.Length; i++)
            {
                Console.WriteLine(circelArray[i].GetDiamter());
            }
        }
    }
}
