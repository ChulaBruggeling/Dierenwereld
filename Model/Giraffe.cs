﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Giraffe : Dier
    {

        public override void Bewegen()
        {
            //bewegen
            x += xRichting;
            y += yRichting;

            //horizontale richting omkeren als de rand van het veld is bereikt
            if (x == xMin || x == xMax)
            {
                xRichting = xRichting * -1;
            }

            //verticale richting omkeren als de rand van het veld is bereikt
            if (y == yMin || y == yMax)
            {
                yRichting = yRichting * -1;
            }
        }
    }
}
