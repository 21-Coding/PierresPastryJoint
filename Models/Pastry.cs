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

      public int PastryCheckout(int pastries)
      {
        PastryTotal = ((pastries / 3) * 5) + (2 * (pastries % 3));
        return PastryTotal;
      }
    }
  }
