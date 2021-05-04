using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program 
  {
    public static void Main()
    {
      Car volkswagon = new Car("2021 Volkswagon GTI", 45000, 125);
      Car ford = new Car("2014 Ford Mustang", 18000, 75000);
      Car buick = new Car("1997 Buick LeSabre", 1500, 225000);
      Car nissan = new Car("2018 Nissan Leaf", 14000, 30000);

      List<Car> Cars = new List<Car>() { volkswagon, ford, buick, nissan };

      Console.WriteLine("What is your maximum price for buying a car?");
      string maxPriceString = Console.ReadLine();
      int maxPrice = int.Parse(maxPriceString);

      List<Car> CarsMatchingBudget = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingBudget.Add(automobile);
        }
      }

      foreach (Car automobile in CarsMatchingBudget)
      {
        Console.WriteLine(automobile.MakeModel);
      }
    }

  }
}