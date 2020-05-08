

namespace Bakery.Models
{
  public class Bread
  {
    public string TypeBread { get; set; }
    public int Price { get; set; }


    // Constructor

    public Bread(string typeBread, int price, int miles)
    {
      BypeBread = typeBread;
      Price = price;
    }
  }

}