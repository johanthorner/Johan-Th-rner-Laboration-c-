using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock myStock = new Stock();

            //Juice juice = new Juice("Krav", 23, "äppleJuice", "Apple");
            //EcoStockitem ecoItem = new EcoStockitem("Krav", 34, "banan");

            //myStock.AddItem(juice);
            //myStock.AddItem(juice);

            //InventoryItem(myStock);

            //myStock.PrintItems();

            //createItemMenu(myStock);


            RunMenu(myStock);
            //testMEtod(myStock);


        }

        private static void InventoryItem(Stock myStock)
        {
            Console.WriteLine("Select item");
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine("how manny?");
            int numberOfItems = int.Parse(Console.ReadLine());
            numberOfItems --;

            for (int i = 0; i <= numberOfItems; i++)
            {
                if (myStock[userSelection] is Stockitem)
                {
                    Stockitem newStockitem = new Stockitem(myStock[userSelection].Id, myStock[userSelection].Name);
                    myStock.AddItem(newStockitem);
                }
            }
        }

        private static void testMEtod(Stock myStock)
        {
            //Stockitem item = new Stockitem(34, "äpple");
            //EcoStockitem ecoItem = new EcoStockitem("Krav", 34, "banan");
            Juice juice = new Juice("Krav", 23, "äppleJuice", "Apple");

            //item = new EcoStockitem("Krav");
            
            myStock.AddItem(juice);
            //myStock.AddItem(item);
            //myStock.AddItem(ecoItem);

            myStock.PrintItems();

        }

        private static void RunMenu(Stock myStock)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("....................");
                Console.WriteLine("1 – Skapa vara");
                Console.WriteLine("2 – Inventera vara");
                Console.WriteLine("3 – Lista varor");
                Console.WriteLine("4 – Avsluta");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        CreateItemMenu(myStock);
                        break;
                    case 2:
                        //inventoryItem(myStock);
                        break;
                    case 3:
                        PrintItems(myStock);
                        break;
                    case 4:
                        Console.WriteLine("Avslutar");
                        programRunning = false;
                        break;
                    default:
                        Console.WriteLine("Inte ett gilltigt val.");
                        break;
                }
                
            }
        }

        private static void PrintItems(Stock myStock)
        {
             myStock.PrintItems();

        }

        private static void CreateItemMenu(Stock myStock)
        {
            bool inputNotComplete = true;
            bool itemCreated = false;
            int inputId = 0;
            string inputName;
            string inputMarkning;
            string inputType;
            
            while (inputNotComplete)
            {
                Console.WriteLine("enter stock type:");
                Console.WriteLine("....................");
                Console.WriteLine("[1] Stock Item");
                Console.WriteLine("[2] Eco stock item");
                Console.WriteLine("[3] Juice");
                Console.WriteLine("[4] Plate");
                Console.WriteLine("[5] Go back");
                int userSelection = int.Parse(Console.ReadLine());
                

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine(" Create stock-item.");
                        inputId = validateIdInput(inputId);

                        Console.WriteLine("Enter Name");
                        inputName = Console.ReadLine();
                        try
                        {
                            Stockitem newStockItem = new Stockitem(inputId, inputName);
                            myStock.AddItem(newStockItem);

                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("Please enter if product is 'EG' or 'Krav'");
                        }



                        break;
                    case 2:
                        Console.WriteLine("Create Eco stock item.");
                        inputId = validateIdInput(inputId);

                        Console.WriteLine("Enter Name");
                        inputName = Console.ReadLine();

                        validateEcoMarking(myStock, itemCreated, inputId, inputName);


                        break;
                    case 3:
                        Console.WriteLine("Juice");
                        Console.WriteLine("Enter id");
                        inputId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        inputName = Console.ReadLine();
                        Console.WriteLine("Enter eco-marking");
                        inputMarkning = Console.ReadLine();

                        Console.WriteLine("Enter type");
                        inputType = Console.ReadLine();

                        Juice newJuiceItem = new Juice(inputMarkning, inputId, inputName, inputType);
                        myStock.AddItem(newJuiceItem);
                        break;
                    case 4:
                        Console.WriteLine("Plate");
                        
                        Console.WriteLine("Enter Name");
                        inputName = Console.ReadLine();
                        Console.WriteLine("Enter eco-marking");
                        inputMarkning = Console.ReadLine();
                        Console.WriteLine("Enter type");
                        inputType = Console.ReadLine();
                        
                        Plate newPlateItem = new Plate(inputType, inputId, inputName);
                        myStock.AddItem(newPlateItem);
                            
                        break;
                    case 5:
                        break;
                        
                    default:
                        Console.WriteLine("Please select a valid option.");
                        inputNotComplete = false;
                        break;
                }
                break;





            }
           
            myStock.PrintItems();
        }

        private static void validateEcoMarking(Stock myStock, bool itemCreated, int inputId, string inputName)
        {
            while (itemCreated == false)
            {
                Console.WriteLine("Enter eco-marking: EG or Krav");
                string inputMarkning = Console.ReadLine();

                try
                {
                    EcoStockitem newEcoStockItem = new EcoStockitem(inputMarkning, inputId, inputName);
                    myStock.AddItem(newEcoStockItem);
                    itemCreated = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Något är fel!");
                    EcoStockitem.stockCount--; //Gör en metod av det här!
                }
            }
        }

        private static int validateIdInput(int inputId)
        {
            Console.WriteLine("Enter id (siffror)");


            bool isIdValid = false;

            while (isIdValid == false)
            {

                bool isInputIdValid = Int32.TryParse(Console.ReadLine(), out inputId);
                if (isInputIdValid == false)
                {
                    Console.WriteLine("not a number try again");

                }
                else
                {

                    isIdValid = true;
                }
            }

            return inputId;
        }



    }
}
