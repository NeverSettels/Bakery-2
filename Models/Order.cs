
namespace Bakery.Models
{
  public class Order
  {
    public List<Bread> BreadOrder { get; }
    public List<Pastry> PastryOrder { get; }

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
  }

}