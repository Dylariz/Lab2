using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1();
        }

        static void Number1()
        {
            Console.Write("Число учеников: ");
            int n = int.Parse(Console.ReadLine());
            int girlsHeight = 0;
            int boysHeight = 0;
            int girlsCount = 0;
            int boysCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите пол (1 - М, 2 - Ж): ");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    boysCount++;
                    Console.Write("Введите рост: ");
                    boysHeight += int.Parse(Console.ReadLine());
                }
                else
                {
                    girlsCount++;
                    Console.Write("Введите рост: ");
                    girlsHeight += int.Parse(Console.ReadLine());
                }
                Console.Clear();
            }
            Console.WriteLine($"Средний рост мальчиков: {boysHeight / boysCount}");
            Console.WriteLine($"Средний рост девочек: {girlsHeight / girlsCount}");
        }

        static void Number4()
        {
            Console.Write("Введите внутренний радиус R1: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Введите внешний радиус R2: ");
            int r2 = int.Parse(Console.ReadLine());
            
            int count = 0;
            Console.Write("Введите N: ");
            for (int i = 0; i < int.Parse(Console.ReadLine()); i++)
            {
                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());
                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (distance <= r2 && distance >= r1)
                    count++;
            }
            Console.WriteLine($"Количество попаданий: {count}");
        }

        static void Number7()
        {
            int count = 0;
            Console.Write("Введите N: ");
            for (int i = 0; i < int.Parse(Console.ReadLine()); i++)
            {
                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());
                int quadrant = 0;
                
                if (x > 0 && y > 0)
                    quadrant =  1;
                else if (x < 0 && y > 0)
                    quadrant =  2;
                else if (x < 0 && y < 0)
                    quadrant =  3;
                else if (x > 0 && y < 0)
                    quadrant =  4;
                Console.WriteLine($"Точка находится в {quadrant} четверти");

                if (quadrant == 1 || quadrant == 3)
                    count++;
            }
            Console.WriteLine($"Количество точек в 1 и 3 четверти: {count}");
        }
    }
}
