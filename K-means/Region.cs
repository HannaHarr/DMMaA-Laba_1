using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace K_means
{
    public class Region
    {
        public List<Dot> dots;

        public Dot core;

        public Color color;

        public Region(Color color, Dot dot, List<Dot> dots)
        {
            this.color = color;
            this.dots = dots;
            core = dot;
        }
    }
}
