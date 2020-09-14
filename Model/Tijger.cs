using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Tijger : Dier
    {

        public override void Bewegen()
        {
            y += yRichting;

            if (y == 9 || y == 0)
            {
                yRichting = yRichting * -1;
            }
        }
    }
}
