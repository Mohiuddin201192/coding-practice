using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<PersonalInformation> list = new List<PersonalInformation>();
      
      while (true)
      {
      Console.WriteLine("First name:");
      string fname = Console.ReadLine();
      if (fname == "")
      {
        break;
      }

      Console.WriteLine("Last name:");
      string lname = Console.ReadLine();

      Console.WriteLine("Identification number:");
      string inum = Console.ReadLine();

      list.Add(new PersonalInformation(fname, lname, inum));
      }
      Console.WriteLine();

      foreach( PersonalInformation item in list)
      {
        Console.WriteLine(item.firstName + " " + item.lastName);
      }
    }
  }
}




