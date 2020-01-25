using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
           var lines = File.ReadAllLines("Dane.txt");
           List<Person> people = lines.Select(x =>
            {
                string[] data = x.Split(',');
                return new Person(
                    data[0],
                    data[1],
                    data[2],
                    Convert.ToInt32(data[3]));
            }).ToList();

            var sortedPeople = people
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.Name);

            StreamWriter writer = new StreamWriter("Result.txt");
            foreach(var item in sortedPeople)
            {
                writer.WriteLine($"[{item.ID}] {item.Name} { item.LastName} {item.Phone}");
            }
        }
    }
}
