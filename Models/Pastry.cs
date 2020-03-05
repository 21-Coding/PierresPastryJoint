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

      public void PastryCheckout()
      {
        PastryTotal = ((PastryCount / 3) * 5) + (2 * (PastryCount % 3));

      }
    }
  }
