using System;
using System.Threading;
using Model;

namespace Dierenwereld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aanmaken dieren
            Aap OnzeAap = new Model.Aap();
            Tijger OnzeTijger = new Model.Tijger();
            Giraffe OnzeGiraffe = new Model.Giraffe();

            Console.SetCursorPosition(0,0);

            for(; ; )
            {
                Console.Clear();

                OnzeAap.Bewegen();
                OnzeAap.TekenDier();

                OnzeTijger.Bewegen();
                OnzeTijger.TekenDier();

                OnzeGiraffe.Bewegen();
                OnzeGiraffe.TekenDier();


                Thread.Sleep(500);
            }
        }
    }
}
