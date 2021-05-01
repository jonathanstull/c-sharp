// using System;

// class HotelCost
// {
//   static void Main()
//   {
//     Console.WriteLine("In what season are you booking a stay?");
//     string season = Console.ReadLine();

//     Console.WriteLine("On a weekend or a weeknight?");
//     string dayOfWeek = Console.ReadLine();

//     bool summer = season == "summer";
//     bool weekend = dayOfWeek == "weekend";

//     if (summer && weekend)
//     {
//       Console.WriteLine("Your stay is probably going to cost you an arm and a leg. Start saving early.");
//     }
//     else if (summer || weekend)
//     {
//       Console.WriteLine("Your stay is probably going to be a bit more expensive than normal.");
//     }
//     else if (!(summer && weekend))
//     {
//       Console.WriteLine("Generally speaking, this is the cheapest possible time to book accommodations.");
//     }
//     else
//     {
//       Console.WriteLine("Your stay might be expensive, but it could be a lot worse.");
//     }
//   }
// }