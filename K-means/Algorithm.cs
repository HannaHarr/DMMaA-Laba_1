using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means
{
    // получает коллекцию точек и коллекцию центральных точек
    // выдает список точек разбитых на области на разных итерациях
    public abstract class Algorithm
    {
        // Основная функция
        public List<Region> Step(List<Dot> dots, List<Dot> centers)
        {
            
        }

        // Разбить на области вокруг центров
        private List<Region> BreakIntoAreas(List<Dot> dots, List<Dot> centers)
        {
            
        }

        // Найти новые ядра
        private int FindNewCore(List<Region>)
        {
            
        }

        // Случайно сгенерировать точки
        public List<Dot> GenerateDots(int count)
        {

        }

        // Нарисовать точки разным цветом
        public void DrawRegions(List<Region> regions)
        {

        }
    }
}
