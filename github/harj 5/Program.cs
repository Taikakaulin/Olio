using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit: ");
            int sec = int.Parse(Console.ReadLine());
            TimeSpan time = TimeSpan.FromSeconds(sec);
            string hours = time.ToString(@"hh");
            string minutes = time.ToString(@"mm");
            string seconds = time.ToString(@"ss");
            Console.WriteLine("antamasi sekuntiaika voidaan ilmaista muodossa: " + hours + " Tuntia " + minutes + " Minuuttia " + seconds + " Sekunttia ");
            Console.ReadLine();
        }
    }
}
