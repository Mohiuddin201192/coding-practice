using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
        list.Add(input);
        //start with the first from the list
        int smallest = list[0];
        // go through our list
        for (int i = 0; i < list.Count; i++)
        {//save current number to int number
          int number = list[i];
          if (smallest > number)
          {
            // number is now stored to the integer "smallest"
            smallest = number;
          }
        }
        // tell what smallest number is
        Console.WriteLine("Smallest number : ")

    }
  }
}
