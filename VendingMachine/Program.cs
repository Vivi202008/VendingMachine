using System;
using VendingMachineApp.Model;
using VendingMachineApp.Data;
using System.Collections.Generic;

namespace VendingMachineApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vending machine!");

            int userSelection;

            VendingMachine vendingMashine = new VendingMachine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1: Show all products.");
                Console.WriteLine("2: Insert money.");
                Console.WriteLine("3: Show your money.");
                Console.WriteLine("4: Buy any number of products.");
                Console.WriteLine("5: Returns money left.");

                Console.WriteLine("999: Quit.");
                Console.WriteLine();
                userSelection = vendingMashine.GetNumberFromUser("Choose a menu selection. ");
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("1. Show all products.");
                        vendingMashine.ShowAll();
                        break;
                    case 2:
                        Console.WriteLine("2: Insert money.");
                        vendingMashine.InsertMoney();
                        break;
                    case 3:
                        Console.WriteLine("3: Show your money.");
                        vendingMashine.ShowMoneyLeft();
                        break;
                    case 4:
                        Console.WriteLine("4: Buy any number of products.");
                        vendingMashine.Purchase();
                        break;
                    case 5:
                        Console.WriteLine("5: Returns money left.");
                        vendingMashine.EndTransaction();
                        break;

                    case 999:
                        Console.WriteLine("Thanks for using this program.");
                        Console.WriteLine("Press any key to close program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }
            } while (userSelection != 999);

        }





    }
}
