namespace Bakery.Models
{
  public class Pastry
  {

    public string TypePastry { get; set; }
    public int Price { get; set; }

    public Pastry(string typePastry, int price, int miles)
    {
      BypePastry = typePastry;
      Price = price;
    }

  }

}