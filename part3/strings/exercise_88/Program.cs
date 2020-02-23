using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
      string text = Console.ReadLine();
      string[] pieces = text.Split(" ");
      if (text == "")
      {
        break;
      }
      Console.WriteLine(pieces[0]);
    }
    }
  }
}



