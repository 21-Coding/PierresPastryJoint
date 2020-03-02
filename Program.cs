using System;
using Pierre;


  public class Program
  {
    public static void Main()
    {
      Bread freshBread = new Bread();
      Pastry freshPastry = new Pastry();

      Console.WriteLine("Pierres Pasty Joint");
      Console.WriteLine("We offer bread by the loaf & pastries as well.  Press 1 for bread & 2 for pastries");
      string userSpeak = Console.ReadLine();

      if (userSpeak == "1")
      {
        Console.Write("Please enter the number of loaves for purchase:  ");
        string loafCount = Console.ReadLine();
        int intLoafCount = int.Parse(loafCount);
      }
      else if (userSpeak == "2")
      {
        Console.WriteLine("Please enter the number of pastries for purchase:  ");
        string pastryCount = Console.ReadLine();
        int intPastryCount = int.Parse(pastryCount);
      }
      else
      {
        Console.WriteLine("Please enter 1 or 2.");
        Main();
      }

      }

    }
