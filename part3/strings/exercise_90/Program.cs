using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int Oldest = 0;
      // read from user
      while (true)
      {
        //integer called Oldest
        
        string question = Console.ReadLine();
        if (question == "")
        // break if empty
        {
          break;
        }
        //split the string into parts[0] parts[1]
        // split the string into name   age
        string[] parts = question.Split (",");
        // check if the age is greater than oldest
        // and convert part[1] into int
        if (Convert.ToInt32(parts[1]) > Oldest)
        {// if true oldest is now part 1 value
          Oldest = Convert.ToInt32(parts[1]);
        }
        
      }
      //execute
      Console.WriteLine("Age of the oldest: " + Oldest);




    }
  }
}



