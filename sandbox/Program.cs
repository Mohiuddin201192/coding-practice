using System;

namespace sandbox
{
    public class Person
{
  public string name { get; }
  public int age { get; set; }
  public int weight { get; set; }
  public int height { get; set; }

  public Person(string name)
  {
    this.age = 0;
    this.weight = 0;
    this.height = 0;
    this.name = name;
  }

  public double BodyMassIndex()
  {
    double heigthPerHundred = this.height / 100.0;
    return this.weight / (heigthPerHundred * heigthPerHundred);
  }

  public void GrowOlder()
  {
    if (this.age < 100)
    {
      this.age = this.age + 1;
    }
  }

  public bool IsOfLegalAge()
  {
    return this.age >= 18;
  }


  public override string ToString()
  {
    return this.name + ", age " + this.age + " years";
  }
}
   
}
