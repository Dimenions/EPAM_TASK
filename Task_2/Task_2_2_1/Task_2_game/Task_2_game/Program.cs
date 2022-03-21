using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Просто тест на компиляцию
            Player pl = new Player(new Point(10, 23));

            Console.WriteLine(pl.Height);

            Player pl2 = new Player(new Point(34, 54))
            {
                Height = 12,
                Width = 324
            };

            Console.WriteLine(pl2.Width);

            Console.ReadLine();
        }
    }
}
