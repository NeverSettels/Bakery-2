using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public List<Bread> BreadOrder { get; set; }
    public List<Pastry> PastryOrder { get; set; }

    public static void AddBread(Bread bread, int quantity)
    {
      for (int i = 0; i <= quantity; i++)
      {
        BreadOrder.Add(bread);
      }
    }
    public void AddPastry(Pastry pastry, int quantity)
    {
      for (int i = 0; i <= quantity; i++)
      {
        PastryOrder.Add(pastry);
      }
    }
    public int SumTotal(Order order)
    {
      int numBreads = order.BreadOrder.Count;
      int numPastries = order.PastryOrder.Count;
      int breadTotal = 0;
      int pastryTotal = 0;
      int numFreeB = numBreads % 2;
      int pastryDiscount = numPastries / 3;

      for (int i = 0; i < numBreads - numFreeB; i++)
      {
        breadTotal += order.BreadOrder[i].Price;
      }
      foreach (Pastry pastry in order.PastryOrder)
      {
        pastryTotal += pastry.Price;
      }
      pastryTotal -= pastryDiscount;
      return pastryTotal + breadTotal;
    }
  }

}