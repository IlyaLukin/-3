using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            double x, y;
            double u;

            do
            {
                Console.WriteLine("Введите x:");
                string name = Console.ReadLine();
                ok = double.TryParse(name, out x);
            } while (!ok);

            do
            {
                Console.WriteLine("Введите y:");
                string name = Console.ReadLine();
                ok = double.TryParse(name, out y);
            } while (!ok);

            if (y >= 0 && y <= 1 && y <= (Math.Pow(Math.E, -x)) && y >= Math.Pow(x, 2) || y >= 0 && y <= 1 && y >= (Math.Pow(Math.E, -x)) && y >= Math.Pow(x, 2))
            {
                Console.WriteLine("Точка принадлежит области D");
                u = x + y;
            }
            else 
            {
            u = x - y;
            Console.WriteLine("Точка не принадлежит области D");
            }
            Console.WriteLine("u={0}", u);
            Console.ReadKey();

        }
    }
}

