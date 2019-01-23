using System;

namespace BobBurger
{
  class Program
  {
    static void Main(string[] args)
    {
      int countburger = 0;
      int countfries = 0;
      int countdrinks = 0;
      int countcombo = 0;

      double burgerprice = 2.99;
      double friesprice = 1.99;
      double drinkprice = 0.99;
      double comboprice = 5.00;
      double taxpercent = 0.06875;
      double userchoice = string.empty;
      string question = "Y";
      string tempnum = string.Empty;
      bool isnumeric = true;

      double subtotal = 0;
      double tax = 0;
      double grandtotal = 0;

      do while (userchoice < 5)
        {
          do
          {
            //TODO: Refactor the menu into its own method
            Console.WriteLine("Select the item you want");
            Console.WriteLine("1) Burger");
            Console.WriteLine("3) Drink");
            Console.WriteLine("4) Combo");
            Console.WriteLine("5) Checkout");
            tempnum = Console.ReadLine();
            isNumeric = double.TryParse(tempnum, out double n);
            if (isNumeric == false || double.Parse(tempnum) <= 0 || double.Parse(tempnum) > 5)
            {
              Console.WriteLine("Please enter a number between 1 and 5");
              isNumeric = false;
            }

          } while (isNumeric == false || double.Parse(tempnum) <= 0 || double.Parse(tempnum) > 5);
          userchoice = double.Parse(tempnum);

          if (userchoice = 1)
            countburger = countburger + 1;
          else if (userchoice = 2)
            countfries = countfries + 1;
          else if (userchoice = 3)
            countdrinks = countdrinks + 1;
          else if (userchoice = 4)
            countcombo = countcombo + 1;
         
        } while (userchoice != 5);
//TODO: refactor this into its own method
      subtotal = (burgerprice * countburer) + (friesprice * countfries) + (drinkprice * countdrink) + (comboprice * countcombo);
      tax = subtotal * taxpercent;
      grandtotal = subtotal + tax;

      Console.WriteLine("You have ordered:");
      Console.WriteLine( countburger +" Buger(s)");
      Console.WriteLine(countfries + " Fries");
      Console.WriteLine(countdrink + " Drink(s)");
      Console.WriteLine(countcombo + " Combo(s)");
      Console.WriteLine("----------------------");
      Console.WriteLine("Subtotal " + subtotal);
      Console.WriteLine ("Tax      " + tax);
      Console.WriteLine ("----------------------");
      Console.WriteLine ("Grand Total " + grandtotal);
//TODO: this does not seem to be compelte, I am not seeing the loop here
      Console.WriteLine("Would you like to do another order (Y/N)");
      Console.ReadLine();

    }

  }
}
