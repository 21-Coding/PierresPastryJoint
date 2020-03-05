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

      public void BreadCheckout()
      {
        BreadTotal = ((5 * (BreadCount % 3)) + (BreadCount / 3 * 10));

      }

    }
  }
