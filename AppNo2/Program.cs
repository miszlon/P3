using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNo2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakąś liczbę");
            string liczba = Console.ReadLine();
            Console.WriteLine("Liczba {0} jest fajna", liczba);
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine(imie);
            Console.ReadKey();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("I");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("I");
                }

            }
            Console.ReadKey();

            if (imie == "Miłosz")
                Console.WriteLine("\nzgadłeś!");
            else Console.WriteLine("Nie zgadłeś :(");
            Console.ReadKey();
        }

    }
}

