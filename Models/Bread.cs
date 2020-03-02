namespace Pierre.Models
{
  public class Bread
  {
    public int BreadCount { get; set; }
    public int BreadTotal { get; set; }

    public Bread(int loaves)
    {
      BreadCount = loaves;
      BreadTotal = 0;
    }
  }
}
