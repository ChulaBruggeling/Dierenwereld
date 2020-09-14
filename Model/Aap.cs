using System;

namespace Model
{
    public class Aap : Dier
    {
        public new string DrawSign = "A";

        public override void Bewegen()
        {
            x += xRichting;

            if (x == 9 || x == 0)
            {
                xRichting = xRichting * -1;
            }
        }

        public override void TekenDier()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(DrawSign);
        }

    }
}
