using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Babelkowe
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args)
        {
            
                int z = 0;
                Console.Write("Podaj rozmiar tablicy: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] tablica = new int[n];
                // wpisywanie do tablicy
                for (int i = 0; i < n; i++)
                {
                    tablica[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                for (int i = n; i > 1; i--)
                {
                    for (int j = 1; j < i; j++)
                    {
                        z++;

                        if (tablica[j - 1] > tablica[j])
                        {
                            Swap(ref tablica[j - 1], ref tablica[j]);
                            Console.WriteLine("Operacja Swap");

                        }
                        Console.Write($"i={i} j={j} tablica: ");
                        for (int h = 0; h < n; h++) { Console.Write(tablica[h]); }
                        Console.Write($" po raz {z}");
                        Console.WriteLine();
                    }
                }
                // wypisanie tablicy
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{tablica[i]} ");
                }
                //cos napisalem Cos na Macu

                Console.ReadLine();
            
        }

    }
}
