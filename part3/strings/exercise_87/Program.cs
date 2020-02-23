using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
    {
      string text = Console.ReadLine();
    
      if (text == "")
      {
        break;
      }
      string [] pieces = text.Split(" ");
      foreach (string line in pieces)

      {
        if (line.Contains("av"))
        {
          Console.WriteLine(line);
        }
      }
   

    }
    }

  }

}

