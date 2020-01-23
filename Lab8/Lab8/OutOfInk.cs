using System;

namespace lab_viii
{
    public class OutOfInkEventArks : EventArgs
    {
        public string color { get; set; }

        public OutOfInkEventArks(string color)
        {
            this.color = color;
        }
    }
}