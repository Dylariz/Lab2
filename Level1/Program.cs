using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number10();
        }

        static void Number1()
        {
            int r = 2;
            double[,] map = { { 0, 1.5, 1, 3 }, { 2, 0.7, 1, 0 } };

            for (int i = 0; i < map.Length / 2; i++)
            {
                if (Math.Abs(Math.Pow(map[0, i], 2) + Math.Pow(map[1, i], 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
                    Console.WriteLine($"Точка ({map[0, i]}, {map[1, i]}) лежит на окружности");
                else
                    Console.WriteLine($"Точка ({map[0, i]}, {map[1, i]}) НЕ лежит на окружности");
            }
        }
        static void Number4()
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Z = {Math.Max(Math.Min(a, b), c)}");
        }

        static void Number7()
        {
            double x = int.Parse(Console.ReadLine());
            double y = 1;
            if (Math.Abs(x) <= 1)
                y = Math.Abs(x);

            Console.WriteLine($"Y = {y}");
        }

        static void Number10()
        {
            double x = int.Parse(Console.ReadLine());
            double y = -1;

            if (x <= -1)
                y = 1;

            else if (x > -1 && x <= 1)
                y = -x;

            Console.WriteLine($"Y = {y}");
        }
    }
}