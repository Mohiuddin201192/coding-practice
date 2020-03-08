using System;
namespace exercise_120
{
    public class Cube
    {
        public int edgeLength;
        public int volume;

        public Cube (int edgeLength)
        {
            this.edgeLength = edgeLength;
            this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
        }
        public int Volume()
        {
            return this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
        }
        public override string ToString()
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + this.volume;
        }
    }
}