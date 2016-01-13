using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj9
{
    class harj9
    {
        static void Main(string[] args)
        {
            int inp = 1, nro = 0;
            while(inp != 0)
            {
                Console.WriteLine("Anna luku: ");
                inp = int.Parse(Console.ReadLine());
                nro += inp;
            }
            Console.WriteLine("Summa on: " + nro);
            Console.ReadLine();
        }
    }
}
