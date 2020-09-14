using System;

namespace Model
{
    public class Aap : Dier
    {
        
        public override void Bewegen()
        {
            if (Richting)
            {
                if (x == 9)
                {
                    Richting = false;
                    x -= 1;
                }
                else
                {
                    x += 1;
                }
            } else
            {
                if (x == 0)
                {
                    Richting = true;
                    x += 1;
                } else
                {
                    x -= 1;
                }
            }
        }
    }
}
