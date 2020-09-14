using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Giraffe : Dier
    {

        public override void Bewegen()
        {
            if (Richting)
            {
                if (x == 9)
                {
                    Richting = false;
                    x -= 1;
                    y -= 1;
                }
                else
                {
                    x += 1;
                    y += 1;
                }
            }
            else
            {
                if (x == 0)
                {
                    Richting = true;
                    x += 1;
                    y += 1;
                }
                else
                {
                    x -= 1;
                    y -= 1;
                }
            }
        }
    }
}
