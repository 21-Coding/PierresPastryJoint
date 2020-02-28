using System;

namespace Pierre.Models
{

  public class Bread
  {
    private string _name { get; set; }
    private string _variety { get; set; }



    public Bread(string name, string variety)
    {

      _name = name;
      _variety = variety;

    }
    public static void ()
    {
      Bread englishMuff = new Bread("English Muffin","Blueberry");
      Bread bagel = new Bread("Bagel","Onion");
      Bread rolls = new Bread("Roll","Honey");

      List<Bread> Bread = new List<Bread>() {englishMuff, bagel, rolls};

    }



  }

  public class Pastry
  {
    private string _name { get; set; }
    private string _type { get; set; }
    private string _variety  { get; set; }




    public Pastry(string name, string type, string variety)
    {
      _name = name;
      _type = type;
      _variety = variety;



    }
    public static void ()
    {

    }


  }


}
