using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int l = 0;
            Console.WriteLine("Podaj rozmiar tablicy: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            //wpisywanie do tablicy
            for(int i =0; i<n; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
                

            }
            // sortowanie przez wstawianie 
         for(int k=1;k<n;k++)
            {
                l = tab[k];
                //ustalone k>=1
                while(k>0 && l<tab[k-1])
                {
                    tab[k] = tab[k - 1];
                    k--;
                }
                tab[k] = l;
            }
            // wypisywanie z tablicy
            for (int i = 0; i < n; i++)
            {
                Console.Write(tab[i]);


            }
            Console.ReadLine();
        }
        
    }
}
