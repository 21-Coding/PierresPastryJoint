using System;
using System.Collections.Generic;
using Pierre.Models;

namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Pastry Joint! Our bread is $5.00 & a pastry is only $2.00");
      Console.WriteLine("We have the following breads:  ");
      Bread englishMuff = new Bread("English Muffin","Blueberry",5);
      Bread bagel = new Bread("Bagel","Onion",5);
      Bread rolls = new Bread("Roll","Honey",5);

      List<Bread> Bread = new List<Bread>() {englishMuff, bagel, rolls};
      Bread.ForEach(Console.WriteLine);

      Console.WriteLine("We have the following pastries:  ");

      Pastry croissant = new Pastry("Croissant","Plain",5);
      Pastry cheeseDanish = new Pastry("Danish","Cheese",5);
      Pastry cheeseCakeCup = new Pastry("Cheesecake Cup","Strawberry",5);

      List<Pastry> Pastry = new List<Pastry>() {croissant, cheeseDanish, cheeseCakeCup};
      Pastry.ForEach(Console.WriteLine);




      Console.WriteLine("To select a bread [enter 1]  To select a pastry [enter 2]");
      string stringBread = Console.ReadLine();
      int intBread = int.Parse(stringBread);

      if (stringBread == "1")
      {
        Console.WriteLine(Bread[0]);
      }
      else if (stringBread == "2")
      {
        Console.WriteLine(Pastry);
      }
      else
      {

      }
    }
  }
}
