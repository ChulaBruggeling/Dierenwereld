using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Giraffe : Dier
    {

        public override void Bewegen()
        {
            x += xRichting;
            y += yRichting;

            if (x == 9 || x == 0)
            {
                xRichting = xRichting * -1;
            }

            if (y == 9 || y == 0)
            {
                yRichting = yRichting * -1;
            }
        }
    }
}
