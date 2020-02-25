using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account myAccount = new Account("My account",100.00);
      myAccount.Deposit(20.0);
      Console.WriteLine(myAccount.balance);

    }
  }
}



