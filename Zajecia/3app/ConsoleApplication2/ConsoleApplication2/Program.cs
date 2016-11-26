using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
            int a = 7;
            int b = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tablica = new int[n];
            // wpisanie do tablicy
            for(int i =0;i<n;i++)
            {
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            // sortowanie bąbelkowe
            for (int i = n; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (tablica[j - 1] > tablica[j])
                    {
                        Swap(ref tablica[j - 1], ref tablica[j]);
                    }
                }
                
            }
            
            
            
            
            
            // wypisanie tablicy
            for (int i = 0; i < n; i++)
            {
                Console.Write(tablica[i]);
            }

           
            Console.ReadLine();
        }

    }
}
