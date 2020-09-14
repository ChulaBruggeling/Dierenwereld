using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Tijger : Dier
    {
        public new string DrawSign = "T";

        public override void Bewegen()
        {
            
            //richting omkeren als de rand van het veld is bereikt
            if (y == yMin || y == yMax)
            {
                yRichting = yRichting * -1;
            }

            //bewegen
            y += yRichting;
        }

        public override void TekenDier()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(DrawSign);
        }
    }
}
