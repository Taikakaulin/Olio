using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Syötä arvostelu: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            int kokonaisuus = num.Sum() - num.Max() - num.Min();
            Console.WriteLine("lopputulos: " + kokonaisuus);
            Console.ReadLine();
        }
    }
}
