using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {

    public string TypePastry { get; set; }
    public int Price { get; set; }

    public Pastry(string typePastry, int price)
    {
      TypePastry = typePastry;
      Price = price;
    }

    public static int PastryDiscount(List<Pastry> PastryOrder)
    {
      int numPastries = PastryOrder.Count;
      int pastryTotal = 0;
      int pastryDiscount = numPastries / 3;
      foreach (Pastry pastry in PastryOrder)
      {
        pastryTotal += pastry.Price;
      }
      pastryTotal -= pastryDiscount;
      return pastryTotal;
    }

  }

}