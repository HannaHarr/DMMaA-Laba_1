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

        public IEnumerable<List<Region>> Process(int countCore, int countDote)
        {
            List<Region> regions = new List<Region>();

            List<Dot> dots = GenerateDots(countDote);
            regions.Add(new Region(beginColor, null, dots));
            yield return regions;

            regions.Clear();
            List<Dot> cores = InitializeCores(countCore, dots);
            dots.RemoveAll(item => cores.Contains(item));

            bool IsContinue;

            do {
                regions = BreakIntoAreas(dots, cores);
                yield return regions;

                dots.AddRange(cores);
                cores.Clear();
                IsContinue = false;
                
                foreach (Region region in regions)
                {
                    IsContinue |= FindNewCore(region);
                    cores.Add(region.core);
                }

                dots.RemoveAll(item => cores.Contains(item));
            } while (IsContinue);

            yield break;
        }

        private List<Dot> InitializeCores(int countCore, List<Dot> dots)
        {
            List<Dot> cores = new List<Dot>();

            for (int i = 0; i < countCore; i++)
            {
                cores.Add(dots[i]);
            }

            return cores;
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

        // Найти новое ядро
        private bool FindNewCore(Region region)
        {
            int X = 0;
            int Y = 0;

            Dot lastCore = region.core;
            region.dots.Add(region.core);

            foreach (Dot dote in region.dots)
            {
                X += dote.X;
                Y += dote.Y;
            }

            region.core = new Dot(X / region.dots.Count, Y / region.dots.Count);

            return !lastCore.Equals(region.core);
        }

        // Случайно сгенерировать точки
        private List<Dot> GenerateDots(int countDot)
        {
            List<Dot> dots = new List<Dot>();

            for (int i = 0; i < countDot; i++)
            {
                dots.Add(new Dot(random.Next(1, 670), random.Next(1, 450)));
            }

            return dots;
        }

        // Нарисовать регионы
        public void DrawRegions(Graphics graph, List<Region> regions)
        {
            foreach (Region region in regions)
            {
                if (region.core != null)
                    graph.FillEllipse(new SolidBrush(coreColor), region.core.X, region.core.Y, region.core.D, region.core.D);

                foreach (Dot dot in region.dots)
                {
                    graph.FillEllipse(new SolidBrush(region.color), dot.X, dot.Y, dot.D, dot.D);
                }
            }
        }
    }
}
