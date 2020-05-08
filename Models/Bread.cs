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
  }

}