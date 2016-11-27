using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while(n%i!=0)
            {
                i++;
            }
            if(i==n)
            {
                Console.WriteLine($"Liczba {n} jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine($"Liczba {n} nie jest liczbą pierwszą");
            }
            Console.ReadKey();
        }
    }
}
