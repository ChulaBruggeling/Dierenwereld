using System;

namespace Model
{
    public class Aap : Dier
    {
        
        public override void Bewegen()
        {
            x += xRichting;

            if (x == 9 || x == 0)
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
