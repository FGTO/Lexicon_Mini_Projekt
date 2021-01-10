using System;
using Asset_Electronics;

namespace Asset_Tracking
{
    class Program
    {
        static void Main(string[] args)
        {
            var done = false;
            var office = "";
            //var officeInput = 0;

            while (!done)
            {
                Console.WriteLine("Which office to add a asset: " + "\n1. Office Sweden" + "\n2. Office Great Britain" + "\n3. Office United States" + "\n4. Office Hong Kong" + "\n5. Quit");
                var officeInput = int.Parse(Console.ReadLine());

                switch (officeInput)
                {
                    case 1:
                        Console.WriteLine("Add asset - SWEDEN\n");
                        office = "SWE";
                        innerSwitch(office);
                        break;
                    case 2:
                        Console.WriteLine("Add asset - GREAT BRITAIN\n");
                        office = "GBR";
                        innerSwitch(office);
                        break;
                    case 3:
                        Console.WriteLine("Add asset - UNITED STATES\n");
                        office =  "US";
                        innerSwitch(office);
                        break;
                    case 4:
                        Console.WriteLine("Add asset - HONG KONG\n");
                        office = "HK";
                        innerSwitch(office);
                        break;
                    case 5:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
        public static void innerSwitch(string office)
        {
            var choosenOffice = office;
            Console.WriteLine("What do you want to add? ");

            var done = false;
            while (!done)
            {
                Console.WriteLine("1. Add new Computer:" + "\n2. Add new phone: " + "\n3. Print all asset." + "\n4. Quit");

                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // TODO function for adding computer
                        Computer.ValidComputerInput(choosenOffice);
                        break;
                    case 2:
                        //TODO function for adding phone
                        Phone.ValidPhoneInput();
                        break;
                    case 3:
                        //TODO function for printing all asset
                        Console.WriteLine("Option 3 not available yet.");
                        break;
                    case 4:
                        //TODO function to terminate the application 
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
        }
    }
}
