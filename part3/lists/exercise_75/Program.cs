using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {


      // Example method calls for testing your method.
      List<int> numbers = new List<int>();
      // numbers.Add(5);
      numbers.Add(9);
      numbers.Add(6);
      numbers.Add(8);
      numbers.Add(-2);
      numbers.Add(5);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);
    }
    public static void PrintNumbersInRange(List<int> numbers,int lowLimit, int highLimit)
    {
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers[i] >= lowLimit && numbers[i] <= highLimit)
        {
          Console.WriteLine(numbers[i]);
        }
      }
    }

    }
  }


