using System;
namespace exercise_124
{
    public class Null
    {
        public string name;
        public int age;
        public Null(string name)
        {
            this.name = name;
            this.age = 0;
        }
        public void Increase(int number)
        {
            this.age = this.age + number;
        }
        public override string ToString() 
        {
            return this.name;
        }
    }
}