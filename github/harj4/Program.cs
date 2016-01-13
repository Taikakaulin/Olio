using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Give me yo age: ");
            age = int.Parse(Console.ReadLine());

            while (age!=0)
            {
                if (age <= 17)
                {
                    Console.WriteLine("Olet alaikäinen");
                    break;
                }
                else if (age >= 18 && age <= 64)
                {
                    Console.WriteLine("Olet aikuinen");
                    break;
                }
                else 
               {
                    Console.WriteLine("Olet seniori");
                    break;
                }
               

            }
        }
    }
}
