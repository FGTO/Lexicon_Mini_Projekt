using System;
using Asset_Tracking;

namespace Asset_Electronics
{
    class Phone : Electronics

    {
        // Constructors
        public Phone(string electronicsType, string model, double purchasePrice, string purchaseDate)
        {
            ElectronicsType = electronicsType;
            Model = model;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }

        public static void ValidPhoneInput()
        {
            // Print and read user inputs.

            bool done = false;
            while (!done)
            {
                Console.Write("Enter the phone brand: ");
                var phoneBrandInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(phoneBrandInput))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                done = true;
            }

            done = false;
            while (!done)
            {
                Console.Write("Enter the phone model: ");
                var phoneModelInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(phoneModelInput))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                done = true;
            }


            ValidatePrice.ValidPrice();
            ValidateDate.ValidDate();


        }
    }
}