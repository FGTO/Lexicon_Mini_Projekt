using System.Collections.Generic;

namespace Asset_Electronics
{
    class Electronics
    {
        public Electronics()
        {
            
        }
        public Electronics(string electronicsType, string brand, string model, double purchasePrice, string purchaseDate)
        {
            ElectronicsType = electronicsType;
            Brand  = brand;
            Model = model;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }
        public string ElectronicsType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double PurchasePrice { get; set; }
        public string PurchaseDate { get; set; }

        public static List<Electronics> Asset {get; set;}

        //public List<Electronics> electronics = new List<Electronics>();
    }


    
}