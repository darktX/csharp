using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potega
{
    class Program
    {
        static public double power(int a,int b)
        {
            double wynik = 1;
            if (b < 0)
            {
                b = System.Math.Abs(b);
                while (b > 0)
                {
                    wynik = wynik * a;
                    b--;
                }

                
                return 1/wynik;
            }
            else
            {
                while (b > 0)
                {
                    wynik = wynik * a;
                    b--;
                }


                return wynik;
            }
        }



        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Wprowadź podstawę potęgi: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wprowadź do której potęgi: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Liczba {a} podniesiona do potęgi {b} wynosi {power(a,b)}");
            Console.ReadLine();
        }
    }
}
