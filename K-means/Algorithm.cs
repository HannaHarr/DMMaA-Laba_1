using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Algorithm
    {
        private protected Random random = new Random();

        private protected Color beginColor = Color.LightSlateGray;

        private protected Color coreColor = Color.Red;

        private protected Color[] colors = { Color.Blue,           Color.Green,          Color.Orange,        Color.Magenta,  Color.Black,
                                             Color.Cyan,           Color.LightSeaGreen,  Color.Sienna,        Color.Purple,   Color.Brown,
                                             Color.CornflowerBlue, Color.DarkOliveGreen, Color.DarkGoldenrod, Color.Maroon,   Color.MidnightBlue,
                                             Color.SlateBlue,      Color.DarkGreen,      Color.IndianRed,     Color.HotPink,  Color.DarkSlateGray };

        private protected int width;

        private protected int hight;
        public Algorithm(int w, int h)
        {
            width = w;
            hight = h;
        }

        // Разбить на области вокруг центров
        private protected List<Region> BreakIntoAreas(List<Dot> dots, List<Dot> cores)
        {
            List<Region> regions = new List<Region>();

            int i = 0;
            foreach (Dot core in cores)
            {
                regions.Add(new Region(colors[i++], core, new List<Dot>()));
            }

            foreach (Dot dote in dots)
            {
                Region region = null;
                double distance = double.PositiveInfinity;

                foreach (Region reg in regions)
                {
                    double dist = Math.Sqrt(Math.Pow(reg.core.X - dote.X, 2) + Math.Pow(reg.core.Y - dote.Y, 2));
                    if (dist < distance)
                    {
                        distance = dist;
                        region = reg;
                    }
                }

                region.dots.Add(dote);
            }

            return regions;
        }

        // Случайно сгенерировать точки
        private protected List<Dot> GenerateDots(int countDot)
        {
            List<Dot> dots = new List<Dot>();

            for (int i = 0; i < countDot; i++)
            {
                dots.Add(new Dot(random.Next(5, width - 5), random.Next(5, hight - 5)));
            }

            return dots;
        }

        // Нарисовать регионы
        public void DrawRegions(Graphics graph, List<Region> regions)
        {
            foreach (Region region in regions)
            {
                foreach (Dot dot in region.dots)
                {
                    graph.FillEllipse(new SolidBrush(region.color), dot.X, dot.Y, dot.D, dot.D);
                }

                if (region.core != null)
                    graph.FillEllipse(new SolidBrush(coreColor), region.core.X, region.core.Y, region.core.D + 5, region.core.D + 5);
            }

            graph.Dispose();
        }
    }
}
