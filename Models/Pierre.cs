using System;

namespace Pierre.Models
{

  public class Bread
  {
    private string _name { get; set; }
    private int _variety { get; set; }


    public Bread(string name, string type, string variety)
    {

      _name = name;
      _variety = variety;

    }
    public static void ()
    {
      Bread englishMuff = new Bread("English Muffin","","Blueberry")

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
