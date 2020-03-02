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
    public int PlusOneB(int thisOne)
    {
      BreadTotal += BreadCheckout(thisOne);
      return BreadTotal;
    }
    public int BreadCheckout(int loaves)
    {
      BreadTotal = (5 * loaves);
      return BreadTotal;
    }
  }
}
