using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    { 
      int oldest = 0;
      int age = 0;
      string name = "";
      int lname = 0;
      int longest = 0;
      string longname = "";
      
      
      while (true)
      {
        string input = Console.ReadLine();
        if (input =="")
        {
          break;
        }
        string[] pieces = input.Split(",");
        age = 2020 - Convert.ToInt32(pieces[1]);
        name = pieces[0];
        lname = name.Length;
        if (oldest < age)

        {
          oldest = age;
        }
        
        if (longest < lname)
        {
          longest = lname;
          longname = name;
        }
      }
      age = 2020 - oldest;
      Console.WriteLine("Longest name: " + name);
      Console.WriteLine("Highest age: " + age);
    


    }
  }
}



