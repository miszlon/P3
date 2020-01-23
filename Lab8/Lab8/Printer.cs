using System;
using System.Collections.Generic;
using System.Text;

namespace lab_viii
{
    class Printer
    {
        private int PaperCount { get; set; }
        private int CyanInk { get; set; }
        private int MagentaInk { get; set; }
        private int YellowInk { get; set; }
        private int BlackInk { get; set; }
        public event EventHandler OutOfPaperEvent;
        public event EventHandler<OutOfInkEventArks> OutOfInkEvent;

        public Printer()
        {
            PaperCount = 100;
            CyanInk = 100;
            MagentaInk = 100;
            YellowInk = 100;
            BlackInk = 100;

            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfInkEvent += OutOfInkEventHandler;
        }
        public void print(int paperCount, int cyanQuality, int magnetaQuality, int yellowQuality, int blackQuality)
        {
            Console.WriteLine("Printing start");

            for (int i = 1; i <= paperCount; i++)
            {
                if (PaperCount <= 0)
                {
                    OutOfPaperEvent?.Invoke(this, EventArgs.Empty);
                    break;
                }

                if (CyanInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArks("Cyan"));
                    break;
                }

                if (MagentaInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArks("Magenta"));
                    break;
                }

                if (YellowInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArks("Yellow"));
                    break;
                }

                if (BlackInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArks("Black"));
                    break;
                }

                PaperCount--;

                CyanInk -= cyanQuality;
                MagentaInk -= magnetaQuality;
                YellowInk -= yellowQuality;
                BlackInk -= blackQuality;

                Console.WriteLine("Kartka " + i + " wydrukowana");
            }



        }

        private void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToLongDateString()} " +
                $"{ DateTime.Now.ToLongTimeString()} | [PrinterLog]: Out of paper");
        }

        private void OutOfInkEventHandler(object sender, OutOfInkEventArks args)
        {

            Console.WriteLine(
                $"{DateTime.Now.ToLongDateString()} " +
                $"{ DateTime.Now.ToLongTimeString()} | [PrinterLog]: Out of {args.color} ink");
        }
    }
}
