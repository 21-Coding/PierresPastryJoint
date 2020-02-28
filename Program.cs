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
          Console.WriteLine("Welcome to Pierres Pastry Joint!");


        }
    }
}
