using System;
using System.Text;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // obliczanie średniej ucznia, jeden przedmiot i nie wiadomi ile ocen
            

            StringBuilder builder = new StringBuilder();

            string text = "@";
            float sum = 0;
            float result = 0;
            Funkcja1 obiekt = new Funkcja1();

            while (text != string.Empty)
            {
                text = Console.ReadLine();
                builder.Append(text + ",");
            }
            string gradesTring = builder.ToString();
            string[] grades = gradesTring.Split(',', StringSplitOptions.RemoveEmptyEntries);

            float[] gradesInt = new float[grades.Length];

            for (int i = 0; i < gradesInt.Length; i++)
            {
                gradesInt[i] = Convert.ToSingle(grades[i]);
            }

            foreach(var grade in gradesInt)
            {
                sum += grade;
            }

            result = obiekt.ObliczSrednia(sum, gradesInt.Length);
            Console.WriteLine(result);

   
        }
    }
}
