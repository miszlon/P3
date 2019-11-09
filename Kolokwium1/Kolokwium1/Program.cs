using System;
using System.IO;

namespace Kolokwium1
{
    class Program
    {
        static void Funkcja(double y, double x)
        {
            double wzor;
            wzor = 0.5 * (x * x) - 10 * (x + 1);

            if (wzor == y)
            {
                Console.WriteLine("Punk należy do wykresu");
            }
            else Console.WriteLine("Punkt nie należy do wykresu");
        }
        static void Main(string[] args)
        {
            string x, y;
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Proszę podać liczbę x: ");
            x = Console.ReadLine();
            Console.WriteLine("Proszę podać liczbę y: ");
            y = Console.ReadLine();
            double m = double.Parse(x);
            double g = double.Parse(y);
            Funkcja(m, g);

        }
    }
}
