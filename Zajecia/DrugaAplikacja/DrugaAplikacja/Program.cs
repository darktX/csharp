using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2, liczba3, liczba4;
            int[] tablica = new int[5];

            tablica[0] = 12;
            tablica[1] = 12;

            Console.WriteLine("Podaj trzecia liczbe: ");
            tablica[2] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Liczba numer trzy to: {tablica[2]}");
            Console.ReadLine();
        


        }
    }
}
