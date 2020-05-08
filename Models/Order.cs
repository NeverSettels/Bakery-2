using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public List<Bread> BreadOrder { get; set; }
    public List<Pastry> PastryOrder { get; set; }

    public void AddBread(Bread bread, int quantity)
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
    public int SumTotal()
    {
      int numBreads = BreadOrder.Count;
      int numPastries = PastryOrder.Count;
      int breadTotal = 0;
      int numFreeB = numBreads % 2;

      for (int i = 0; i < numBreads - numFreeB; i++)
      {
        breadTotal += BreadOrder[i].Price;
      }


    }
  }

}