using System;
namespace exercise_113
{
    public class Book
    {
        public string Name {get;}
        public int Pages{get; set;}
        public int Year{get; set;}

        public Book(string Name,int Pages,int Year)
        {
            this.Name = Name;
            this.Pages = Pages;
            this.Year = Year;
        }
        public override string ToString()
        {
            return this.Name + ", " + this.Pages + " pages" + ", " + this.Year;
        }
    }
}