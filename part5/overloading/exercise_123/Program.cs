using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();
      Console.WriteLine(counter.value);
      counter.Increase();

      Console.WriteLine(counter.value);
      counter.Increase(12);

      Console.WriteLine(counter.value);
      counter.Decrease();

      Console.WriteLine(counter.value);
      counter.Decrease(6);
    }
  }
}
