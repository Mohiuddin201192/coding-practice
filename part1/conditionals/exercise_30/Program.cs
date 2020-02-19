using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string num = Console.ReadLine();
      int grade = Convert.ToInt32(num);
      if (grade <  0)
      {
        Console.WriteLine("Impossible");
      }
      else if (grade > 0 && grade < 50)
      {
         Console.WriteLine("Fail");
      }
      else if (grade > 49 && grade < 60)
      { 
        Console.WriteLine("Grade: 1");
      }
      else if (grade > 59 && grade < 70)
      {
         Console.WriteLine("Grade: 2");
      }
      else if (grade > 69 && grade < 80)
      {
         Console.WriteLine("Grade: 3");
      }
      else if (grade >79 && grade < 90)
      {
         Console.WriteLine("Grade: 4");
      }
      else if (grade >89 && grade <= 100)
      {
         Console.WriteLine("Grade: 5");
      }
      else
      {
         Console.WriteLine("Outstanding!");
      }




    }
  }
}
