using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj_10
{
    class Harj10
    {
        static void Main(string[] args)
        {
           
            Console.Write("Syötä haluamasi rivien määrä");
            int inp = int.Parse(Console.ReadLine());
            for (int i = 0; i < inp; i++)
            {
                Console.Write("*");
                for(int k =0; k <i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
            
        }
    }

