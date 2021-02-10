using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    // получает коллекцию точек и коллекцию центральных точек
    // выдает список точек разбитых на области на разных итерациях
    public class K_means : Algorithm
    {
        public K_means(int w, int h) : base(w, h)
        {
        }

        public IEnumerable<List<Region>> Process(int countCore, int countDote)
        {
            List<Region> regions = new List<Region>();

            List<Dot> dots = GenerateDots(countDote);
            regions.Add(new Region(beginColor, null, dots));
            yield return regions;

            regions.Clear();
            List<Dot> cores = GenerateDots(countCore);

            bool IsContinue;

            do {
                regions = BreakIntoAreas(dots, cores);
                yield return regions;

                cores.Clear();
                IsContinue = false;
                
                foreach (Region region in regions)
                {
                    IsContinue |= FindNewCore(region);
                    cores.Add(region.core);
                }

            } while (IsContinue);

            yield break;
        }

        public IEnumerable<List<Region>> Process(List<Region> regions)
        {
            List<Dot> dots = new List<Dot>();
            List<Dot> cores = new List<Dot>();

            foreach (Region region in regions)
            {
                dots.AddRange(region.dots);
                dots.Add(region.core);
            }

            bool IsContinue = false;

            foreach (Region region in regions)
            {
                IsContinue |= FindNewCore(region);
                cores.Add(region.core);
            }

            while (IsContinue)
            {
                regions = BreakIntoAreas(dots, cores);
                yield return regions;

                cores.Clear();
                IsContinue = false;

                foreach (Region region in regions)
                {
                    IsContinue |= FindNewCore(region);
                    cores.Add(region.core);
                }
            }

            yield break;
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

            return !Equals(lastCore, region.core);
        }
    }
}
