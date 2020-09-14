using System;
using System.Collections.Generic;
using System.Threading;
using Model;

namespace Dierenwereld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>();

            //Aanmaken dieren
            Aap OnzeAap = new Model.Aap();
            dieren.Add(OnzeAap);

            Tijger OnzeTijger = new Model.Tijger();
            dieren.Add(OnzeTijger);

            Giraffe OnzeGiraffe = new Model.Giraffe();
            dieren.Add(OnzeGiraffe);

            Console.SetCursorPosition(0,0);

            for(; ; )
            {
                Console.Clear();

                OnzeAap.Bewegen();
                OnzeTijger.Bewegen();
                OnzeGiraffe.Bewegen();
                
                OnzeAap.TekenDier(dieren);
                OnzeTijger.TekenDier(dieren);
                OnzeGiraffe.TekenDier(dieren);

                


                Thread.Sleep(500);
            }
        }
    }
}
