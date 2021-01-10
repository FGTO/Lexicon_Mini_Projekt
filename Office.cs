using System;
using System.Collections.Generic;
using Asset_Electronics;

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


        public static void addAsset(string officeName, string electronicsType, string brand, string model, double purchasePrice, string purchaseDate)
        {
            if (officeName == "SWE")
            {
                //TODO add item to Swedish of(fice list.
                officeSWE.Add(electronicsType, brand, model, purchasePrice, purchaseDate);
            }
        }


        public static string OfficeName { get; private set; }
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