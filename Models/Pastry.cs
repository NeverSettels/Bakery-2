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
      TypeSlow($"Everytime you buy 3 pastries you get $5 off! you got ${(pastryDiscount * 5)} off this Order!");
      pastryTotal -= (pastryDiscount * 5);
      return pastryTotal;
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