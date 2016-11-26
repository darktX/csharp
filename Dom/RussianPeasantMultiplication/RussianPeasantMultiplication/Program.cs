using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasantMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int wynik = 0;
            Console.WriteLine("Wprowadź a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź b:");
            int b = Convert.ToInt32(Console.ReadLine());
            // algorytm mnożenia rosyjskich chłopów
            while (b != 1)
            {
                if (b % 2 != 0)
                {
                    //b jest liczbą nieparzystą
                    wynik = wynik + a;
                }
                a = a * 2;
                b = b / 2;
            }
            wynik = wynik + a;
            Console.WriteLine($"Wynik mnożenia to: {wynik}");
            Console.ReadKey();

        }
    }
}
