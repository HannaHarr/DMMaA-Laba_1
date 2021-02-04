using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means
{
    // получает коллекцию точек и коллекцию центральных точек
    // выдает список точек разбитых на области на разных итерациях
    public abstract class Algorithm
    {
        private Random random = new Random();

        private Color beginColor = Color.LightSlateGray;

        private Color coreColor = Color.Red;

        private Color[] colors = { Color.Blue,           Color.Green,          Color.Orange,        Color.Magenta,  Color.Black,
                                   Color.Cyan,           Color.ForestGreen,    Color.Sienna,        Color.Purple,   Color.Brown,
                                   Color.CornflowerBlue, Color.DarkOliveGreen, Color.DarkGoldenrod, Color.Maroon,   Color.MidnightBlue,
                                   Color.SlateBlue,      Color.LightSeaGreen,  Color.IndianRed,     Color.DeepPink, Color.DarkSlateGray };

        // Итеративная функция
        public List<Region> Step(List<Dot> dots, List<Dot> cores)
        {
            
        }

        // Разбить на области вокруг центров
        private List<Region> BreakIntoAreas(List<Dot> dots, List<Dot> cores)
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
                double Distance = double.PositiveInfinity;

                foreach (Region reg in regions)
                {
                    double dist = Math.Sqrt(Math.Pow(reg.center.X - dote.X, 2) + Math.Pow(reg.center.Y - dote.Y, 2));
                    if (dist < Distance) 
                    {
                        Distance = dist;
                        region = reg;
                    }
                }

                region.dots.Add(dote);
            }

            return regions;
        }

        // Найти новое ядро
        private Dot FindNewCore(Region region)
        {
            
        }

        // Случайно сгенерировать точки
        public Region GenerateDots(int countDot)
        {
            List<Dot> dots = new List<Dot>();

            for (int i = 0; i < countDot; i++)
            {
                dots.Add(new Dot(random.Next(1, 670), random.Next(1, 450)));
            }

            return new Region(beginColor, null, dots);
        }

        // Нарисовать регион
        public void DrawRegion(Graphics graph, Region region)
        {
            if (region.center != null)
                graph.FillEllipse(new SolidBrush(coreColor), region.center.X, region.center.Y, region.center.D, region.center.D);

            foreach (Dot dot in region.dots)
            {
                graph.FillEllipse(new SolidBrush(region.color), dot.X, dot.Y, dot.D, dot.D);
            }
        }
    }
}
