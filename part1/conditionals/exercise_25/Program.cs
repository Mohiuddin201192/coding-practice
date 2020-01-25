using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string nmbr = Console.ReadLine();
      int value = Convert.ToInt32(nmbr);
      if (value == 1984)
      {
        Console.WriteLine("Orwell");
      }


    }
  }
}
