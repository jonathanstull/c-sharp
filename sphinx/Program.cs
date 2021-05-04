using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Bridge
{
  public class Program
  {
    public static void Main()
    {
      Riddle one = new Riddle("What is your favorte color", "blue");
      
      Console.WriteLine(one.question);
      string guess = Console.ReadLine();

      if (guess != one.answer)
      {
        Console.WriteLine("You are WRONG. Try again...");
      }
      else if (guess == one.answer)
      {
        Console.WriteLine("You are correct and may live... for now.");
      }
    }
  }
}


      // List<Riddle> Riddles = new List<Riddle>() { "What is your favorite color?" };
      // List<Answer> Answers = new List<Answer>() { "blue" };
      //Dictionary<string, string> Riddles = new Dictionary<string, string>() { {"What is your favorite color", "blue"} }
