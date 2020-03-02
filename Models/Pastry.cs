namespace Pierre.Models
{
  public class Pastry
  {
    public int PastryCount {get; set; }
    public int PastryTotal { get; set; }

    public Pastry(int pastries)
    {
      PastryCount = pastries;
      PastryTotal = 0;
    }
    public int PlusOneP(int thisOne)
    {
      PastryTotal += PastryCheckout(thisOne);
      return PastryTotal;
    }
    public int PastryCheckout(int pastries)
    {
      PastryTotal = ((2 * pastries) + (pastries / 3) * 5);
      return PastryTotal;
    }
  }
}
