using System;

namespace Колонна_с_разными_диаметрами_таблеток
{

    enum Color
    {
        Blue,
        Green   
    }
    class Program
    {
        static void Main(string[] args)
        {
            // вводим поле
            int length, percentLuquid, totalTablet, FieldArea;
            double percent, percentTablet, EX;
            string str;

            Console.WriteLine("Введите длину поля");
            str = Console.ReadLine();
            length = Convert.ToInt32(str);
            Point[,,] Field = new Point[length, length, length];

            FieldArea = length * length * length;
           
            Console.WriteLine("Введите процентное содержание жидкости");
            str = Console.ReadLine();
            percentLuquid = Convert.ToInt32(str);
            percentTablet = 100 - percentLuquid;
            Console.WriteLine("Процентное содержание жидкости :" + percentLuquid + "%");
            Console.WriteLine("Процентное содержание твердого вещества :" + percentTablet + "%");

            percent = percentTablet / 100;
            EX = FieldArea * percent;
            totalTablet = (int)EX;
            Console.WriteLine("Сколько ячеек в поле для таблеток :"+totalTablet);

            Random rnd = new Random();

            //создаем среду
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Field[i, j, 0] = new Point(concentration: 0);
                    Field[i, j, 0].color = Color.Blue;
                }
            }
            int Number = 1;
            int tabletsBOX =0;
            //начнем расставлять рандомно таблетки
            while (tabletsBOX< totalTablet)
            {
                int X = rnd.Next(0, length);
                int Y = rnd.Next(0, length);
                if (Field[X, Y, 0].Concentration == 0)
                {
                    Field[X, Y, 0].Concentration = 1;
                    Field[X, Y, 0].color = Color.Green;
                    Tablet tablet = new Tablet(FieldArea);

                    //if (X - tablet.GetR() < 0)
                    //{
                    //    int x = length + (X - tablet.GetR());
                    //}
                    //if (X + tablet.GetR() > length)
                    //{
                    //    int x = ;
                    //}
                    for (int i = X - tablet.GetR(); i <= X + tablet.GetR(); i++)
                    {
                        for (int j = Y - tablet.GetR(); j <= Y + tablet.GetR(); j++)
                        {
                            if (Field[i, j, 0].Concentration == 0)
                            {
                                Point p = new Point(1);
                                p.X = i;
                                p.Y = j;
                                p.Z = 0;
                                pointList.Add(p);
                                Field[i, j, 0].Concentration = 1;
                                Field[i, j, 0].color = Color.Green;
                            }
                            else
                            {
                                tablet.SetR(tablet.GetR());
                                // полностью очищаем список
                                //Tablet.Clear();
                            }
                        }
                    }
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            var col = (X + i + length) % length;//если заходим за левый край - он является правым
                            var row = (Y + j + length) % length;
                            var isSelfChecking = col == X && row == Y;
                            var hasLife = Field[col, row, 0];
                        }
                    }
                }
            }
        }
    }
}
