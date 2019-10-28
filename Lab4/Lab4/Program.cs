using System;

namespace lab_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 1;
            int[] tablica = { 1, 2, 2, 3, 4 };

          
            int zmienna = 1;

            Console.WriteLine("PRZED\n" + zmienna);

            Stworz(out zmienna);

            Console.WriteLine("PO\n" + zmienna);

        }

        static void Stworz(out int zmienna)
        {
            zmienna = 5;
        }

        public static void poszarpanaTablica()
        {
            int[][] poszarpana =
            {
                new[] {1, 2 ,3},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2}
            };

            int[][] nowaPoszarpana = new int[poszarpana.Length][];

            for (int i = 0; i < poszarpana.Length; i++)
            {
                nowaPoszarpana[i] = new int[poszarpana[i].Length];
                //poszarpana[i].CopyTo(nowaPoszarpana[i], 0);
                nowaPoszarpana[i] = KopiujTablice(poszarpana[i]);
            }

            nowaPoszarpana[1][3] = 100;

            for (int i = 0; i < poszarpana.Length; i++)
            {
                for (int j = 0; j < poszarpana[i].Length; j++)
                {
                    Console.Write(poszarpana[i][j] + " ");
                }
                Console.Write(Environment.NewLine);
            }

            Console.Write(Environment.NewLine);

            for (int i = 0; i < nowaPoszarpana.Length; i++)
            {
                for (int j = 0; j < nowaPoszarpana[i].Length; j++)
                {
                    Console.Write(nowaPoszarpana[i][j] + " ");
                }
                Console.Write(Environment.NewLine);
            }

        }

        static int[] KopiujTablice(int[] tablica)
        {
            int[] nowaTablica = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
                nowaTablica[i] = tablica[i];
            return nowaTablica;
        }

        static void Proba(ref int liczba, int[] tablica)
        {
            liczba = -100;
            tablica[0] = -100;
        }
    }
}
