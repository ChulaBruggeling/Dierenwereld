using System;

namespace Model
{
    public class Aap : Dier
    {
        
        public override void Bewegen()
        {
            //bewegen
            x += xRichting;

            //richting omkeren als de rand van het veld is bereikt
            if (x == xMin || x == xMax)
            {
                xRichting = xRichting * -1;
            }
        }

        public void TekenDier()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("A");
        }
    }
}
