using System;
using System.Collections.Generic;
using Pierre.Models;

namespace Pierre
{
    public class Program
    {
        public static void Main()
        {
          Bread englishMuff = new Bread("English Muffin","Blueberry",5);
          Bread bagel = new Bread("Bagel","Onion",5);
          Bread rolls = new Bread("Roll","Honey",5);

          List<Bread> Bread = new List<Bread>() {englishMuff, bagel, rolls};
          Console.WriteLine("Welcome to Pierres Pastry Joint! Our bread is $5.00 & a pastry is only $2.00.");

          Pastry croissant = new Pastry("Croissant","Plain",5);
          Pastry cheeseDanish = new Pastry("Danish","Cheese",5);
          Pastry cheeseCakeCup = new Pastry("Cheesecake Cup","Strawberry",5);

          List<Pastry> Pastry = new List<Pastry>() {croissant, cheeseDanish, cheeseCakeCup};
          Console.WriteLine("Welcome to Pierres Pastry Joint! Our bread is $5.00 & a pastry is only $2.00.");


          Console.WriteLine("To select a bread enter 1.");
          string stringBread = Console.ReadLine();
          int intBread = int.Parse(stringBread);

          Console.WriteLine("To select a pastry enter 2.");
          string stringPastry = Console.ReadLine();
          int intPastry = int.Parse(stringPastry);






        }
    }
}
