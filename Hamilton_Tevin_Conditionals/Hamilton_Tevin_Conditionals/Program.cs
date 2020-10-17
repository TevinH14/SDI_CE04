using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tevin Hamilton
             * 03/05/2018
             * conditionals
             * */
            Console.Clear();

            // problem 1 
            Console.WriteLine("please enter the weight amount");
            string weightAmountString = Console.ReadLine();
            double weightAmount;
            if (!(double.TryParse(weightAmountString, out weightAmount)))
            {
                Console.WriteLine("please don't leave blank ");
                weightAmountString = Console.ReadLine();
            }

            Console.WriteLine("please enter weight type (g or oz ) ");
            string weightScaleString = Console.ReadLine();
            if (weightScaleString.ToLower() != "g" && weightScaleString.ToLower() != "oz")
            {               
                Console.WriteLine("Please only answer g or oz!\r\n please enter weight type (g or oz )?\r\n");                
                weightScaleString = Console.ReadLine();
            }

            double ounces;
            double grams;

            if (weightScaleString.ToLower() == "g")
            {
                ounces = weightAmount / 28.34952;
                Console.WriteLine($"The weight is {ounces} in ounces\r\n");
            }
            else if (weightScaleString.ToLower() == "oz")
            {
                grams = weightAmount * 28.34952;
                Console.WriteLine($"The weigh is {grams} in Grams\r\n");
            }
            /*problem 1 Test 
             * weight - 200  units g = 7.054479
             * weight 12 units oz = 340.194
             * weight 50 units OZ = 1417.476
             * weight 150 units G= 5.29109
             * */
             
            


             
            // problem 2 

            //pizza per person
            Console.WriteLine("Please enter how many pizzas you order\r\n");
            string pizzaOrderString = Console.ReadLine();
            int pizzaOrder;
            if (!(int.TryParse(pizzaOrderString, out pizzaOrder)))
            {
                Console.WriteLine("please enter a number only\r\n");
                Console.WriteLine("please enterhow many pizzas you order\r\n");
                pizzaOrderString = Console.ReadLine();
            }
            Console.WriteLine("please enter how many slices per pizza\r\n");
            string slicesPerString = Console.ReadLine();
            int slicesPer;
            if (!(int.TryParse(slicesPerString, out slicesPer)))
            {
                Console.WriteLine("please enter a number only\r\n");
                Console.WriteLine("please enter how many pizzas per pizza\r\n");
                slicesPerString = Console.ReadLine();
            }
            Console.WriteLine("please enter how many guest will be at your party\r\n");
            string guestString = Console.ReadLine();
            int guest;
            if (!(int.TryParse(guestString, out guest)))
            {
                Console.WriteLine("please enter a whole number\r\n");
                Console.WriteLine("please enter howm many guest will be at your party\r\n");
                guestString = Console.ReadLine();
            }
            Console.WriteLine("please enter the amount of slices each guest will have.\r\n");
            string slicesPerGuestString = Console.ReadLine();
            int slicesPerGuest;
            if (!(int.TryParse(slicesPerGuestString, out slicesPerGuest)))
            {
                Console.WriteLine("please enter a whole number.\r\n");
                Console.WriteLine("please enter the amount of slices each guest will have.\r\n");
                slicesPerGuestString = Console.ReadLine();
            }
            int pizzaPie = pizzaOrder * slicesPer;
            int guestPizza = guest * slicesPerGuest;
            if (pizzaPie > guestPizza)
            {
                int partyPizza = pizzaPie - guestPizza;
                Console.WriteLine($"yes you have enough pizza with {partyPizza} left over.\r\n");
            }
            else
            {
                int partyGuest = guestPizza - pizzaPie;
                
                Console.WriteLine($"yous need at least {partyGuest} slices of pizza, you should order more\r\n");
            }
            /*problem 2 test 
             * pizza 10 , pizza slices per 8 , guest count 11, guest per slice 5 =25 left over 
             * pizza 5 - slices per pizza 6 ,guest count 8  , slices per guest 5 = 10 more slices needed
             * pizza 8 - slices per pizza 10 ,guest count 12 , slices per guest 4 = 32 left over 
             * */

            
            //problem 3

            Console.WriteLine("Hello please enter your yearly income then press enter\r\n");
            string userIncomeString = Console.ReadLine();
            decimal userIncome;
            if (!(decimal.TryParse(userIncomeString, out userIncome)))
            {
                Console.WriteLine("please don't leave blank or type in numbers\r\n");
                Console.WriteLine("what is your yearly income\r\n");
                userIncomeString = Console.ReadLine();
            }
            if (userIncome <= 9000)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 1 and your tax rate is 10%.\r\n");
            }
            else if (userIncome >= 9325 && userIncome < 37950)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 2 and your tax rate is 15%.\r\n");
            }
            else if (userIncome >= 37950 && userIncome < 91900)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 3 and your tax rate is 25%.\r\n");
            }
            else if (userIncome >= 91900 && userIncome < 191650)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 4 and your tax rate is 28%.\r\n");
            }
            else if (userIncome >= 191650 && userIncome < 416700)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 5 and your tax rate is 33%.\r\n");
            }
            else if (userIncome >= 416700 && userIncome < 418400)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 6 and your tax rate is 35%.\r\n");
            }
            else if (userIncome >= 418400)
            {
                Console.WriteLine($"You have an income of {userIncome.ToString("c")} which puts you in tier 7 and your tax rate is 39.6%.\r\n");
            }
            /*Problem 3 test
             *  income  $63234 , tier 3 with 25% tax
             *  income $200000 , tier 5 with 33% tax
             *  income  $500000 , tier 7 with 39.6% tax
             *  income $25000 , tier 2 with 15%%
             * */

            // problem 4 

            Console.WriteLine("whats the price for item 1\r\n");
            string item1String = Console.ReadLine();
            decimal item1;
            if (!(decimal.TryParse(item1String, out item1)))
            {
                Console.WriteLine("please enter a number\r\nWhat the cost of item1\r\n");
                item1String = Console.ReadLine();
            }
            Console.WriteLine("what is the price for item 2\r\n");
            string item2String = Console.ReadLine();
            decimal item2;
            if (!(decimal.TryParse(item2String, out item2)))
            {
                Console.WriteLine("please tyope in a number");
                Console.WriteLine("what is the proice for item 2");
                item2String = Console.ReadLine();
            }
            decimal itemPrice = item1 + item2;
            if (itemPrice >= 100)
                
            {
                decimal  tenDiscount = .1m;
                decimal discount1 = tenDiscount * itemPrice;
                decimal finalPrice1 =  discount1-itemPrice;
                Console.WriteLine($"your final total will be {finalPrice1.ToString("c")} with a 10% discount");
            }
            else if ((itemPrice >= 50) && (itemPrice < 100))
            {
                decimal fiveDiscount = .05m;
                decimal discount2 = fiveDiscount*itemPrice;
                decimal finalPrice2 = discount2-itemPrice;
                Console.WriteLine($"your final total will be {finalPrice2.ToString("c")} with a 5% discount");
            }
            else if (itemPrice<50)
            {
                Console.WriteLine($"your final total is {itemPrice} with no discount");
            }
            /*problem 4 test 4
             * item 1 - $45.50 , item 2 - $75.00 = $108.45 with 10% discount
             * item 1 - $30.00, item 2 -$25.00 = $52.25 with 5% discount
             * item 1 - $5.75, item 2 - $12.50 = $18.25 with no discount 
             * item 1 - $13.50, item 2 - $24.75 = 38.25 with no discount  
             * */


            
        }
    }    
}
