using System;

namespace exercise_120
{
  class Program
  {
    public static void Main(string[] args)
    {
      Cube newcube = new Cube(4);
      newcube.Volume();
      Console.WriteLine(newcube);
    }
  }
}
