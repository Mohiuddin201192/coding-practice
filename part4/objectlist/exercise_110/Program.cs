using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Item> names = new List<Item>();
      while (true)
      {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }
        names.Add (new Item(name));

      }
        
        foreach (Item name in names)
        {
          Console.WriteLine(name);
        }
    }
  }
}




