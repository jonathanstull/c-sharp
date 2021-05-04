using System;

namespace Dealership.Models
{
  public class Car
  {
    private string _MakeModel;
    private int _Price;
    private int _Miles;

    public Car(string makeModel, int price, int miles)
    {
      _MakeModel = makeModel;
      _Price = price;
      _Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}