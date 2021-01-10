using System;
using System.Collections.Generic;
using Asset_Electronics;
using Asset_Tracking;

namespace Subsidiaries
{
    class Office
    {
        public Office(string officeName, string electronicsType, string brand, string model, double purchasePrice, string purchaseDate)
        {
            OfficeName = officeName;
            ElectronicsType = electronicsType;
            Brand = brand;
            Model = model;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }

        public Office(string electronicsType, string brand, string model, double purchasePrice, string purchaseDate)
        {
            ElectronicsType = electronicsType;
            Brand = brand;
            Model = model;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }


        public static void addAsset(string officeName, Electronics el)
        {
            if (officeName == "SWE")
            {
                //TODO add item to Swedish of(fice list.
                
                Electronics.Assets.Add(el);
                
                Console.WriteLine($"List count: {Electronics.Assets.Count}");

                //foreach (Electronics item in el)
                //{
                //    Console.WriteLine(item);
                //}
            }
            Console.WriteLine("INTE SVERIGE");




        }

        //List<Electronics> electronics = new List<Electronics>();
        public string OfficeName { get; private set; }
        public string ElectronicsType { get; private set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double PurchasePrice { get; set; }
        public string PurchaseDate { get; set; }

        private static List<Office> officeHK = new List<Office>();
        private static List<Office> officeGBR = new List<Office>();
        private static List<Office> officeUS = new List<Office>();
        private static List<Office> officeSWE = new List<Office>();



        //public List<Computer> Computers { get; set; }
        //public List<Phone> Phones { get; set; } */
    }

}