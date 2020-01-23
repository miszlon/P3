using System;

namespace lab_viii
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.OutOfPaperEvent += OutOfPaperEventHandler;
            printer.OutOfInkEvent += OutOfInkEventHandler;
            printer.print(230, 1, 1, 1, 3);

        }

        static void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Printer ran out of paper, please put new paper");
        }

        static void OutOfInkEventHandler(object sender, OutOfInkEventArks args)
        {
            Console.WriteLine($"Printer ran out of { args.color}, please put new {args.color} ink");
        }
    }
}
