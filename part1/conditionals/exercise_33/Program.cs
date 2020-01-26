using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
      string veg = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string veg1 = Console.ReadLine();

      if (veg == veg1)
      {
        Console.WriteLine("Echo!");
      }
  
      else
      {
        Console.WriteLine("Nope!");
      }
    


    }
  }
}
