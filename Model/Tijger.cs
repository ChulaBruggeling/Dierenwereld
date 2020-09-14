using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Tijger : Dier
    {

        public override void Bewegen()
        {
            if (Richting)
            {
                if (y == 9)
                {
                    Richting = false;
                    y -= 1;
                }
                else
                {
                    y += 1;
                }
            }
            else
            {
                if (y == 0)
                {
                    Richting = true;
                    y += 1;
                }
                else
                {
                    y -= 1;
                }
            }
        }
    }
}
