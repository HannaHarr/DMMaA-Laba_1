using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Maxmin : Algorithm
    {
        public Maxmin(int w, int h) : base(w, h)
        {
        }

        public IEnumerable<List<Region>> Process(int countDote)
        {
            List<Region> regions = new List<Region>();

            List<Dot> dots = GenerateDots(countDote - 1);
            regions.Add(new Region(beginColor, null, dots));
            yield return regions;

            regions.Clear();
            List<Dot> cores = GenerateDots(1);

            Dot newCore;

            do
            {
                regions = BreakIntoAreas(dots, cores);
                yield return regions;

                newCore = FindNewCore(regions);

                if (newCore != null)
                {
                    cores.Add(newCore);
                    dots.Remove(newCore);
                }

            } while (newCore != null);

            yield break;
        }

        // Найти новое ядро
        private Dot FindNewCore(List<Region> regions)
        {
            Dot newCore = null;
            double distance = double.NegativeInfinity;
            double mean = 0;
            Region reg = null;

            // в каждом регионе выбрать самую дальнюю точку
            for (int i = 0; i < regions.Count(); i++)
            {
                reg = regions[i];
                foreach(Dot dote in reg.dots)
                {
                    double dist = Math.Sqrt(Math.Pow(reg.core.X - dote.X, 2) + Math.Pow(reg.core.Y - dote.Y, 2));
                    if (dist > distance)
                    {
                        distance = dist;
                        newCore = dote;
                    }
                }

                // считаем арифметическое расстояние
                for (int j = i + 1; j < regions.Count(); j++)
                {
                    mean += Math.Sqrt(Math.Pow(reg.core.X - regions[j].core.X, 2) + Math.Pow(reg.core.Y - regions[j].core.Y, 2));
                }
            }

            if ((regions.Count() < 2) || (distance > mean / (regions.Count() * (regions.Count() - 1))))
            {
                return newCore;
            }

            return null;
        }
    }
}
