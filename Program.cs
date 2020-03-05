  using System;
  using Pierre.Models;

  namespace Pierre
  {
    public class Program
    {
      public static void QuickText(string line)
      {
        for (int i = 0; i < line.Length; i++)
          {
            Console.Write(line[i]);
            System.Threading.Thread.Sleep(50);
          }
      }
      public static void Main()
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Black;
        QuickText("Thank You for shopping at Pierre's Pastry Joint!");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        QuickText("Please provide a name for the order: ");
        string orderName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.White;
        QuickText("Todays bread special is:  " + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
        QuickText("Blueberry Hard Dough Bread." + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
        QuickText("$5 per loaf or buy 2, get one on us!" + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.Blue;
        QuickText("How many loaves would you like?" + Environment.NewLine);


        int breadCount = int.Parse(Console.ReadLine());
        Bread freshLoaf = new Bread(breadCount);
        freshLoaf.BreadCheckout();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;
        QuickText("Todays pastry special is:  " + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
        QuickText("Strawberry Cheesecake Cups." + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
        QuickText("$2 per pastry or $5 for 3!" + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.Blue;
        QuickText("How many pastries would you like?");

        int pastryCount = int.Parse(Console.ReadLine());
        Pastry freshOne = new Pastry(pastryCount);
        freshOne.PastryCheckout();

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.Black;
        QuickText("Thank you " + orderName + " your total order is: " + Environment.NewLine);
        QuickText("$" + breadAccount + pastryAccount + ".00");



      }
    }
  }
