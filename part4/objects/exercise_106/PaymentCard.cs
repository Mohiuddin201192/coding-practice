using System;
namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
      this.balance = openingBalance;
    }

    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}