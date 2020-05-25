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
  }

}