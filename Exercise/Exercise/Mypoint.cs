using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Mypoint
    {
        private int X, Y;

        public Mypoint()
        {
            this.X = this.Y = 0;
        }

        public Mypoint(int x, int y)
        {
            this.X = x;
            Y = y;
        }

        public int getX()
        {
            return this.X;
        }

        public void setX(int x)
        {
            this.X = x;
        }

        public int getY()
        {
            return this.Y;
        }

        public void setY(int y)
        {
            this.Y = y;
        }

        public int[] getXY()
        {
            // Cachs 1
            //int[] xy = new int[2];
            //xy[0] = this.X;
            //xy[1] = this.Y;
            //return xy;

            // Cach 2
            return new int[] { this.X, this.Y };
        }

        public void setXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", this.X, this.Y);
        }

        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.X - x,2) + Math.Pow(this.Y - y,2));
        }

        public double distance(Mypoint point)
        {
            return distance(point.getX(), point.getY());
        }

        public double distance()
        {
            return distance(0, 0);
        }
    }
}
