using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0; i<3; i++)
            {
                Console.Write("Syötä luku: ");
                num[i] = int.Parse(Console.ReadLine());
            }
           Console.WriteLine("Suurin luku on: " + num.Max());
           Console.ReadLine();
        }
    }
}
