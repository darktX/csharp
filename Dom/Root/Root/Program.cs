using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę dla której ma zostać wyznaczony pierwiastek: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 1;
            double b = n;
            Console.Write("Podaj do jakiego przybliżenia: ");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            while (Math.Abs(a-b)>epsilon)
            {
                a = (a - b) / 2;
                b = n / a;
            }
            Console.WriteLine($"Pierwiastek z {n} w przybliżeniu {epsilon} wynosi {b}");

            Console.ReadKey();
        }
    }
}
