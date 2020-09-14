using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Dier
    {
        public string DrawSign = "*";
        public int x;
        public int y;
        public int xRichting = 1;
        public int yRichting = 1;
        public int xMin = 0;
        public int xMax = 9;
        public int yMin = 0;
        public int yMax = 9;

        public Dier()
        {
            Random randm = new Random();
            x = randm.Next(0, 10);
            y = randm.Next(0, 10);
        }

        public virtual void Bewegen()
        {

        }

        public virtual void TekenDier()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(DrawSign);
        }
    }
}
