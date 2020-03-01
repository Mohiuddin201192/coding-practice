using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Book> list = new List<Book>();
      while (true)
      {
      Console.Write("Name: ");
      string Name = Console.ReadLine();
      if (Name == "")
      {
        break;
      }
      Console.Write("Pages: ");
      int Pages = Convert.ToInt32(Console.ReadLine());
      Console.Write("Publication year: ");
      int Year = Convert.ToInt32(Console.ReadLine());

      list.Add (new Book(Name, Pages, Year));
    }
      Console.WriteLine();
      Console.Write("What information will be printed? ");
      string everything = Console.ReadLine();

      foreach (Book item in list)
      {
        if (everything == "everything")
        {
          Console.WriteLine(item);
        }
        else if (everything == "title")
        {
          Console.WriteLine(item.Name);
        }
        else
        {
          break;
        }
      }
      
    }
  }
}




