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
      for (int i = 0; i < numBreads - numFreeB - 1; i++)
      {
        breadTotal += BreadOrder[i].Price;
      }
      TypeSlow($"You bought {numBreads} and thanks to our buy 2 get 1 free discount you get {numFreeB} pieces for free");
      return breadTotal;
    }

    public static void TypeSlow(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(50);
      }
      Console.WriteLine();
    }
  }
}