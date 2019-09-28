using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string odpowiedz = Console.ReadLine();
            int liczba = Convert.ToInt32(odpowiedz);

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else Console.WriteLine("Nieparzysta");

            Console.Read();
        }
    }
}

