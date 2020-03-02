using System;

namespace Pierre
{

  class Bread
  {
    public int Price { get; set; }



    public Bread()
    {

       Price = 5;
     }


    public int breadCheckout(int indivBreads)
    {
      if (indivBreads == 1)
      {
        Price == 5;
      }
      else
      {
        Console.WriteLine("error");
    }
    return Price;
  }

  class Pastry
  {
    public int Price { get; set; }




    public Pastry()
    {

      Price = 2;

    }

    public int pastryCheckout(int indivPastries)
    {
      if (indivPastries == 1)
      {
        Price == 5;
      }
      else
      {
        Console.WriteLine("error");
    }
    return Price;
    }



  }


}
}
