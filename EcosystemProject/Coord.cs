using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
    public class Coord
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coord()
        {
        }

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool isWithin(int xMin, int xMax, int yMin, int yMax)
        {
            return (x >= xMin && x <= xMax && y >= yMin && y <= yMax);
        }

        public double getDistSqrd(Coord b)
        {
            double xDisSqrd = x - b.x;
            xDisSqrd = xDisSqrd * xDisSqrd;
            double yDisSqrd = y - b.y;
            yDisSqrd = yDisSqrd * yDisSqrd;
            return (xDisSqrd + yDisSqrd);
        }

        public double getDistance(Coord b)
        {
            return Math.Sqrt(getDistSqrd(b));
        }

        public override string ToString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        static public Coord coordAt(int x, int y)
        {
            Coord c = new Coord(x, y);
            return c;
        }

        public static Coord operator +(Coord a, Coord b) 
        {
            return new Coord(a.x + b.x, a.y + b.y);
        }

        public static Coord operator -(Coord a, Coord b)
        {
            return new Coord(a.x - b.x, a.y - b.y);
        }

        public static Coord operator *(Coord a, double b)
        {
            int nX = Convert.ToInt32(a.x * b);
            int nY = Convert.ToInt32(a.y * b);
            return new Coord(nX, nY);
        }

        public static Coord operator /(Coord a, double b)
        {
            if (b != 0)
            {
                int nX = Convert.ToInt32(a.x / b);
                int nY = Convert.ToInt32(a.y / b);
                return new Coord(nX, nY);
            }
            else return new Coord(0, 0);
        }

        public static bool operator ==(Coord a, Coord b)
        {
            if (object.ReferenceEquals(a, null) )
            {
                return object.ReferenceEquals(b, null);
            }
            if (object.ReferenceEquals(b, null) )
            {
                return object.ReferenceEquals(a, null);
            }
            return (a.x == b.x && a.y == b.y);
        }

        public static bool operator !=(Coord a, Coord b)
        {
            return !(a == b);
        }
    }
}
