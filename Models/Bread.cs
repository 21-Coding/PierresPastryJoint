  using System;
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

      public int BreadCheckout(int loaves)
      {
        BreadCount = ((5 * (loaves % 3)) + (loaves / 3 * 10));
        return BreadTotal;
      }

    }
  }
