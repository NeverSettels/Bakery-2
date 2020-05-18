using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public static List<Bread> BreadOrder { get; set; }
    public static List<Pastry> PastryOrder { get; set; }

    public static void AddBread(Bread bread, int quantity)
    {
      for (int i = 0; i <= quantity; i++)
      {
        BreadOrder.Add(bread);
      }
    }
    public static void AddPastry(Pastry pastry, int quantity)
    {
      for (int i = 0; i <= quantity; i++)
      {
        PastryOrder.Add(pastry);
      }
    }
    public static int SumTotal()
    {
      int numBreads = BreadOrder.Count;
      int numPastries = PastryOrder.Count;
      int breadTotal = 0;
      int pastryTotal = 0;
      int numFreeB = numBreads % 2;
      int pastryDiscount = numPastries / 3;

      for (int i = 0; i < numBreads - numFreeB; i++)
      {
        breadTotal += BreadOrder[i].Price;
      }
      foreach (Pastry pastry in PastryOrder)
      {
        pastryTotal += pastry.Price;
      }
      pastryTotal -= pastryDiscount;
      return pastryTotal + breadTotal;
    }
  }

}