using System;

namespace Asset_Tracking
{
    public class ValidatePrice
    {
        public ValidatePrice()
        {

        }
        public ValidatePrice(string purchasePriceInput)
        {
            PurchasePriceInput = purchasePriceInput;
        }

        public static double ValidPrice()
        {
            var priceInput = "";
            var isValidPrice = 0.0;
            var done = false;
            while (!done)
            {
                double price = 0.0;
                Console.Write("Enter the purchase price: ");
                priceInput = Console.ReadLine();
                if (priceInput == "q" || priceInput == "Q")
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(priceInput))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                else if (double.TryParse(priceInput, out price) == false)
                {
                    Console.WriteLine("Invalid purchase price. Please try again.");
                    continue;
                }
                isValidPrice = double.Parse(priceInput);
                break;
            }
            return isValidPrice;
        }

        private string PurchasePriceInput;

    }
}