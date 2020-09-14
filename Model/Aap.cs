using System;

namespace Model
{
    public class Aap : Dier
    {
        public new string DrawSign = "A";

        public override void Bewegen()
        {
            //richting omkeren als de rand van het veld is bereikt
            if (x == xMin || x == xMax)
            {
                xRichting = xRichting * -1;
            }

            //bewegen
            x += xRichting;

        }

        public override void TekenDier()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(DrawSign);
        }

    }
}
