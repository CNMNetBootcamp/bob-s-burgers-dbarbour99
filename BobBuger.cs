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
      double userchoice = 0;
      string question = "Y";
      string tempnum = string.Empty;
      bool isNumeric = true;

      double subtotal = 0;
      double tax = 0;
      double grandtotal = 0;
      do
      {
        Menu(ref countburger, ref countfries, ref countdrinks, ref countcombo, ref userchoice, ref tempnum, ref isNumeric);

        CalcTotals(countburger, countfries, countdrinks, countcombo, burgerprice, friesprice, drinkprice, comboprice, taxpercent, out subtotal, out tax, out grandtotal);

        DisplayResults(countburger, countfries, countdrinks, countcombo, subtotal, tax, grandtotal);//

        Console.WriteLine("Would you like to do another order (Y/N)");
        question = Console.ReadLine();

        ResetCounts(out countburger, out countfries, out countdrinks, out countcombo, out userchoice);

      } while (question == "Y");
    }

    private static void ResetCounts(out int countburger, out int countfries, out int countdrinks, out int countcombo, out double userchoice)
    {
      userchoice = 0;
      countburger = 0;
      countfries = 0;
      countdrinks = 0;
      countcombo = 0;
    }

    private static void CalcTotals(int countburger, int countfries, int countdrinks, int countcombo, double burgerprice, double friesprice, double drinkprice, double comboprice, double taxpercent, out double subtotal, out double tax, out double grandtotal)
    {
      subtotal = (burgerprice * countburger) + (friesprice * countfries) + (drinkprice * countdrinks) + (comboprice * countcombo);
      tax = subtotal * taxpercent;
      grandtotal = subtotal + tax;
    }

    private static void Menu(ref int countburger, ref int countfries, ref int countdrinks, ref int countcombo, ref double userchoice, ref string tempnum, ref bool isNumeric)
    {
      do while (userchoice < 5)
        {
          do
          {
            Console.WriteLine("Select the item you want");
            Console.WriteLine("1) Burger");
            Console.WriteLine("2) Fries");
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

          if (userchoice == 1)
            countburger = countburger + 1;
          else if (userchoice == 2)
            countfries = countfries + 1;
          else if (userchoice == 3)
            countdrinks = countdrinks + 1;
          else if (userchoice == 4)
            countcombo = countcombo + 1;

        } while (userchoice != 5);
    }

    private static void DisplayResults(int countburger, int countfries, int countdrinks, int countcombo, double subtotal, double tax, double grandtotal)
    {
      Console.WriteLine("You have ordered:");
      Console.WriteLine(countburger + " Buger(s)");
      Console.WriteLine(countfries + " Fries");
      Console.WriteLine(countdrinks + " Drink(s)");
      Console.WriteLine(countcombo + " Combo(s)");
      Console.WriteLine("----------------------");
      Console.WriteLine("Subtotal " + subtotal);
      Console.WriteLine("Tax      " + tax);
      Console.WriteLine("----------------------");
      Console.WriteLine("Grand Total " + grandtotal);
    }
  }
}
