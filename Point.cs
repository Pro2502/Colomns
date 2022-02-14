using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Колонна_с_разными_диаметрами_таблеток
{
    class Point
    {
        public Color color;
        public int X;
        public int Y;
        public int Z;
        public bool IsSolid { get; private set; }
        public bool Luquid { get; private set; }

        int concentration;
        public int Concentration
        {
            set
            {
                concentration = value;
            }
            get
            {
                return concentration;
            }
        }
        public Point(int concentration)
        {
            this.concentration = concentration;
            IsSolid = CalcSolid();
            Luquid = CalcLuquid();
        }
        public bool CalcSolid()
        {
            return concentration == 1;

        }
        public bool CalcLuquid()
        {
            return concentration == 0;

        }
    }
    class Globule
    {
        public List<Point> pointList = new List<Point>();
    }
}
