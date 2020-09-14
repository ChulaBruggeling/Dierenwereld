using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Dier
    {
        public int x = 0;
        public int y = 0;
        public int xRichting = 1;
        public int yRichting = 1;
        public int xMin = 0;
        public int xMax = 9;
        public int yMin = 0;
        public int yMax = 9;

        public virtual void Bewegen()
        {

        }
    }
}
