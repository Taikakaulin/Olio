using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1;
            int nro2;
            int nro3;
            Console.Write("syötä ensimmäinen luku: ");
            nro1 = int.Parse(Console.ReadLine());
            Console.Write("syötä toinen luku: ");
            nro2 = int.Parse(Console.ReadLine());
            Console.Write("syötä kolmas luku: ");
            nro3 = int.Parse(Console.ReadLine());

            Console.WriteLine("lukujen summa" + (nro1 + nro2 + nro3));
            Console.WriteLine("lukujen keskiarvo" + (nro1 + nro2 + nro3) / 3);



        }
    }
}
