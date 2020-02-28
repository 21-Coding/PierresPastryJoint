using System;

namespace Pierre.Models
{

  public class Bread
  {
    private string _name { get; set; }
    private string _variety { get; set; }
    private int _price { get; set; }



    public Bread(string name, string variety, int price)
    {

      _name = name;
      _variety = variety;
      _price = price;

    }

    
    public void BreadCheckout()
    {

    }

  }

  public class Pastry
  {
    private string _name { get; set; }
    private string _type { get; set; }
    private int _price { get; set; }




    public Pastry(string name, string type, int price)
    {
      _name = name;
      _type = type;
      _price = price;



    }



  }


}
