using System;
using System.Globalization;

namespace Asset_Tracking
{
    public class ValidateDate
    {
        public ValidateDate()
        {

        }

        public ValidateDate(string purchaseDateInput)
        {
            PurchaseDateInput = purchaseDateInput;
        }

        public static string ValidDate()
        {
            var dateInput = "";
            bool done = false;
            while (!done)
            {
                
                Console.Write("Enter purchase date (yyyy-mm-dd): ");
                dateInput = Console.ReadLine();

                if (dateInput == "q" || dateInput == "Q")
                {
                    break;
                }

                CultureInfo enDE = new CultureInfo("en-DE");
                DateTime dateValue;

                var formatStrings = new string[] { "MM/dd/yyyy", "yyyy-MM-dd" };
                if (DateTime.TryParseExact(dateInput, formatStrings, enDE, DateTimeStyles.None, out dateValue) == false)
                {
                    Console.WriteLine("Wrong date format. Please try again.");
                    continue;
                }
                break;
            }
            return dateInput;

        }


        private string PurchaseDateInput;

    }


}