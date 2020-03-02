using System;
using Pierre.Models;

namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Thank You for shopping at Pierre's Pastry Joint");
      Console.Write("Please provide a name for the order: ");
      string orderName = Console.ReadLine();
      Console.WriteLine("We provide a small but organic & homeade menu:  ");
      Console.WriteLine("Blueberry Hard Dough Bread.");
      Console.WriteLine("$5 per loaf or buy 2, get one on us!");
      Console.WriteLine("How many loaves would you like?");

      int breadCount = int.Parse(Console.ReadLine());
      Bread freshLoaf = new Bread(breadCount);
      int breadAccount = freshLoaf.BreadCheckout(breadCount);

    }
  }
}
