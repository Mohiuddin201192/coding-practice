using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string question = Console.ReadLine();
        if (question == "")
        // break if empty
        {
          break;
        }
        //split the question into parts[0] parts[1]
        // create an array called 'parts'
        // method split takes a parameter
        // split the string into name   age
        string[] parts = question.Split (" ");
        foreach (string line in parts)
        {
          Console.WriteLine(line);
        }
      }
        


    }
  }
}

