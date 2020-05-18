using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string TypeBread { get; set; }
    public int Price { get; set; }

    public Bread(string typeBread, int price)
    {
      TypeBread = typeBread;
      Price = price;
    }

    public static int BreadDiscount(List<Bread> BreadOrder)
    {
      int numBreads = BreadOrder.Count;
      int breadTotal = 0;
      int numFreeB = numBreads % 2;
      for (int i = 0; i < numBreads - numFreeB; i++)
      {
        breadTotal += BreadOrder[i].Price;
      }
      return breadTotal;
    }


  }
}