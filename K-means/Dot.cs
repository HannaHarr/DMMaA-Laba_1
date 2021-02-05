using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means
{
    public class Dot
    {
        public int D = 4;

        public int X;

        public int Y;

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;

            Dot dot = (Dot)obj;
            return (X == dot.X && Y == dot.Y);
        }
    }
}
