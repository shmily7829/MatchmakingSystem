using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class Coord
    {
        public Coord(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }

        public float Y { get; set; }

        public double Distance(Coord coord)
        {
            return Math.Sqrt(Math.Pow(X - coord.X, 2) + Math.Pow(Y - coord.Y, 2));
        }
    }
}
