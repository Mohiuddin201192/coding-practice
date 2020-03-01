using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<TelevisionProgram> list = new List<TelevisionProgram>();

      while (true)
      {
        Console.Write("Name: ");
        string Name = Console.ReadLine();

        if (Name == "")
        {
          break;
        }
        Console.Write("Duration: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        list.Add (new TelevisionProgram(Name, duration));
      }
        Console.WriteLine();
        Console.Write("Program's maximum duration? ");
        int minutes =Convert.ToInt32(Console.ReadLine());

        foreach (TelevisionProgram item in list)
        {
          if (item.duration <= minutes)
        
        {
          Console.WriteLine (item);
        }
      }
      
        

    }
  }
}




