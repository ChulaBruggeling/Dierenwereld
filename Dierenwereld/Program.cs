using System;
using Model;

namespace Dierenwereld
{
    class Program
    {
        static void Main(string[] args)
        {
            Aap OnzeAap = new Aap();
            Tijger OnzeTijger = new Model.Tijger();
            Giraffe OnzeGiraffe = new Model.Giraffe();
            Console.WriteLine("OnzeAap\nStap1");
            Console.WriteLine(OnzeAap.x);
            Console.WriteLine(OnzeAap.y);
            OnzeAap.Bewegen();
            Console.WriteLine("Stap2");
            Console.WriteLine(OnzeAap.x);
            Console.WriteLine(OnzeAap.y);
            OnzeAap.Bewegen();
            Console.WriteLine("Stap3");
            Console.WriteLine(OnzeAap.x);
            Console.WriteLine(OnzeAap.y);
            OnzeAap.Bewegen();
            Console.WriteLine("Stap4");
            Console.WriteLine(OnzeAap.x);
            Console.WriteLine(OnzeAap.y);

            Console.WriteLine("\nOnzeTijger\nStap1");
            Console.WriteLine(OnzeTijger.x);
            Console.WriteLine(OnzeTijger.y);
            OnzeTijger.Bewegen();
            Console.WriteLine("Stap2");
            Console.WriteLine(OnzeTijger.x);
            Console.WriteLine(OnzeTijger.y);

            Console.WriteLine("\nOnzeGiraffe\nStap1");
            Console.WriteLine(OnzeGiraffe.x);
            Console.WriteLine(OnzeGiraffe.y);
            OnzeGiraffe.Bewegen();
            Console.WriteLine("Stap2");
            Console.WriteLine(OnzeGiraffe.x);
            Console.WriteLine(OnzeGiraffe.y);

        }
    }
}
