using System;

namespace exercise_126
{
  class Program
  {
    public static void Main(string[] args)
    {
      PaymentTerminal lunchCafeteria = new PaymentTerminal();
      double change = lunchCafeteria.DrinkCoffee(0);
      Console.WriteLine("remaining change " + change);

      change = lunchCafeteria.DrinkCoffee(4);
      Console.WriteLine("remaining change " + change);

      change = lunchCafeteria.EatLunch (3);
      Console.WriteLine("remaining change " + change);

      Console.WriteLine(lunchCafeteria);
    }
  }
}
