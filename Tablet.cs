using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Колонна_с_разными_диаметрами_таблеток
{
    public class Tablet
    {
        //создание разных диаметров
        Random rnd = new Random();
        int lagestDiameter, D;
        public int R;
        double TabletArea;
        public Tablet(int FieldArea)
        {
            lagestDiameter = Convert.ToInt32(Math.Sqrt(FieldArea));
            Console.WriteLine("Наибольший диаметр таблетки :" + lagestDiameter);
            int[] massiv = new int[lagestDiameter];
            int Index = rnd.Next(massiv.Length);
            D = Index + 1;
            Console.WriteLine("Выводим диаметр таблетки :" + D);
            R = D / 2;
            //Console.WriteLine("Выводим радиус таблетки :" + R);
            //TabletArea = (R ^ 2) * 3.14;
            //Console.WriteLine(TabletArea);
        }
        public int SetR(int R)
        {
            this.R = R - 1;
            return R;
        }
        public int GetR()
         {
            return R;
         } 
    }
}
