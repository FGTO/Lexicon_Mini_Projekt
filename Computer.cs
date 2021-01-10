using System;
using System.Collections.Generic;
using Asset_Tracking;
using Subsidiaries;
// Test change 
namespace Asset_Electronics
{
    class Computer : Electronics
    {
        public Computer()
        {
            
        }
        public Computer(string officeName)
        {
            OfficeName = officeName;
        }
        public Computer(string officeName, string electronicsType, string model, double purchasePrice, string purchaseDate)
        {
            OfficeName = officeName;
            ElectronicsType = electronicsType;
            Model = model;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }

        public static void ValidComputerInput(string choosenOffice)
        {
            var currentOffice = choosenOffice;
            //List<Computer> computers = new List<Computer>();
            string computerBrandInput = "";
            string computerModelInput = "";

            // Print and read user inputs.
            bool done = false;
            while (!done)
            {
                Console.Write("Enter the computer brand: ");
                computerBrandInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(computerBrandInput))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                done = true;
            }

            done = false;
            while (!done)
            {
                Console.Write("Enter the computer model: ");
                computerModelInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(computerModelInput))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                done = true;
            }

            var isValidPrice = ValidatePrice.ValidPrice();
            var isValidDate = ValidateDate.ValidDate();

            Office.addAsset(currentOffice, "Computer", computerBrandInput, computerModelInput, isValidPrice, isValidDate);
            /*
            computers.Add(new Computer(computerBrandInput, computerModelInput, isValidPrice, isValidDate));

             foreach (Computer item in computers)
            {
                Console.WriteLine("\n" + item.ElectronicsType + " " + item.Model + " " + item.PurchasePrice + " " + item.PurchaseDate);
            } */
        }
        public string OfficeName { get; set; }

    }
}
