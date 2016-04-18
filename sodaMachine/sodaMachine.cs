using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using proper code design, write a SodaMachine class that accepts coins as payment, returns
// coins from its limited register as change, and dispenses soda cans from its limited inventory.


// Make a class for each coin(penny, nickel, dime, quarter) that sets its value in its constructor** incomplete
// Allow payment via passing a List of coins into a public function on the SodaMachine class


// If not enough money is passed in, don't complete transaction: give the money back
// If exact change is passed in, accept payment and dispense a soda from the limited inventory.** completed
// If too much money is passed in, accept the payment, return change as a list of coins from internal.** completed

// limited register, and return a soda instance from internal, limited inventory. ** completed

// If too much money is passed in but there isn't sufficient change in the machine's internal register, don't complete transaction: give the money back. * incomplete
// If exact or too much money is passed in but there isn't sufficient inventory for that soda, don't complete the transaction: give the money back. * incomplete




// The machine should start with:
// Coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies **
// Cans: Grape-flavored(60¢ per), Orange-flavored(35¢ per), Meat-flavored(6¢ per)** completed

namespace sodaMachine
{

    class sodaMachine
    {
        List<Currency> UScurrency = new List<Currency>();
        List<Currency> Wallet = new List<Currency>();

      

        Decimal grapeCan = .60m;
        Decimal orangeCan = .35m;
        Decimal meatCan = .06m;

        //List<>

        public Decimal depositedAmount;

        private Decimal internalRegister = 22.50m;

        public sodaMachine()
        {
            depositedAmount = 0;

            //generateQuarters();
            //generateDimes();
            //generateNickels();
            //generatePennies();
            //generateGrapeSoda();
            //generateOrangeSoda();
            //generateMeatSoda();


        }
        public void acceptCoins(/*List<Currency>*/ int currency)
        {
            //UScurrency.AddRange(currency);
            switch (currency)
            {
                case (1):
                    depositedAmount += .01m;
                    break;
                case (5):
                    depositedAmount += .05m;
                    break;
                case (10):
                    depositedAmount += .10m;
                    break;
                case (25):
                    depositedAmount += .25m;
                    break;
                default:
                    Console.WriteLine("Invalid entry:  Please enter 1, 5, 10 or 25 please");
                    break;
            }

        }
       

        public void sodaSelection()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("* QUENTIN'S SODA MACHINE *");
            Console.WriteLine("**************************\n");

            Console.WriteLine("1 - Grape Soda     $.60");
            Console.WriteLine("2 - Orange Soda    $.35");
            Console.WriteLine("3 - Meat Soda      $.06");
            Console.WriteLine();
            Console.WriteLine("Please Make your Selection: (1, 2 or 3)");
            selectSoda(Convert.ToInt32(Console.ReadLine()));
        }
        //UScurrency.Add(new Quarter());

        public void selectSoda(int selection)
        {
            bool selectOK = false;
            while (!selectOK)
            {
                switch (selection)
                {
                    case (1):
                        Console.WriteLine("Here is your Grape Soda!");
                        grapeRefund();
                        selectOK = true;
                        
                        break;
                    case (2):
                        Console.WriteLine("Here is your Orange Soda!");
                        orangeRefund();
                        selectOK = true;
                        
                        break;
                    case (3):
                        Console.WriteLine("Here is your Meat Soda!");
                        meatRefund();
                        selectOK = true;
                       
                        break;
                    default:
                        Console.WriteLine("Invalid Selction: Enter your selection again please!");
                        selection = Convert.ToInt32(Console.ReadLine());
                        selectOK = false;
                        break;
                }
            }
        }


       
        public void grapeRefund()
        {
            if (depositedAmount > grapeCan)
                Console.WriteLine("Here is your change: {0:C}", depositedAmount - grapeCan);
        }
        public void orangeRefund()
        {
            if (depositedAmount > orangeCan)
                Console.WriteLine("Here is your change: {0:C}", depositedAmount - orangeCan);
        }
        public void meatRefund()
        {
            if (depositedAmount > meatCan)
                Console.WriteLine("Here is your change: {0:C}", depositedAmount - meatCan);
        }


        public bool checkGrapeTotal()
        {
            if (depositedAmount >= grapeCan)
            {
                //grapeRefund();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkOrangeTotal()
        {
            if (depositedAmount >= orangeCan)
            {
                //orangeRefund();
                return true;
            }
            else
            {
                return false;
            }
        }
    public bool checkMeatTotal()
        { 
            if (depositedAmount >= meatCan)
            {
                //meatRefund();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}   
    
      
     

 