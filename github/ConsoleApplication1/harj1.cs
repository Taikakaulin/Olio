using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class harj1
    {
        static void Main(string[] args)
        {
            int luku; 
            Console.Write("anna Luku: ");
            //luku = int.Parse(Console.ReadLine());
            string rivi = Console.ReadLine();
            bool onnistuiko = int.TryParse(rivi, out luku);
            if (onnistuiko)
            {
                switch (luku) //switch valintalause
                {
                    case 1:
                        Console.WriteLine("Annoit yksi");
                        break;
                    case 2:
                        Console.WriteLine("Annoit kaksi");
                        break;
                    case 3:
                        Console.WriteLine("Annoit luvun kolme");
                        break;
                    default:
                        Console.WriteLine("joku muu luku");
                        break;


                }

            }
            else
            {
                Console.WriteLine("et antanut lukua");
            }
        }
    }
}
