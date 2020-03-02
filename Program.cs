using System;
using Pierre.Models;

namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Thank You for shopping at Pierre's Pastry Joint!");
      Console.Write("Please provide a name for the order: ");
      string orderName = Console.ReadLine();

      Console.WriteLine("Todays bread special is:  ");
      Console.WriteLine("Blueberry Hard Dough Bread.");
      Console.WriteLine("$5 per loaf or buy 2, get one on us!");
      Console.WriteLine("How many loaves would you like?");


      int breadCount = int.Parse(Console.ReadLine());
      Bread freshLoaf = new Bread(breadCount);
      int breadAccount = freshLoaf.BreadCheckout(breadCount);

      Console.WriteLine("Todays pastry special is:  ");
      Console.WriteLine("Strawberry Cheesecake Cups.");
      Console.WriteLine("$2 per pastry or $5 for 3!");

      Console.WriteLine("How many pastries would you like?");

      int pastryCount = int.Parse(Console.ReadLine());
      Pastry freshOne = new Pastry(pastryCount);
      int pastryAccount = freshOne.PastryCheckout(pastryCount);

      Console.Clear();
      Console.WriteLine();
      Console.WriteLine("Thank you " + orderName + " Your total order is: ");
      Console.WriteLine("$" + breadAccount + pastryAccount + ".00");



    }
  }
}
