using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //meglio chiamare direttamente il metodo Move, e dargli come proprietà le newLocation
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
            
            //defense programming
            if(newLocation == null)
                throw  new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}