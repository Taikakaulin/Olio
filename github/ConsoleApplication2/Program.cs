using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float matka;
            Console.WriteLine("Syötä matka: ");
            matka = float.Parse(Console.ReadLine());
            Console.WriteLine("Bensaa kuluu: " + (matka / 100) * 7.02 +" litraa");
            Console.WriteLine("Rahaa meni: " + ((matka / 100) * 7.02) * 1.595 + " euroa");
        }
    }
}
