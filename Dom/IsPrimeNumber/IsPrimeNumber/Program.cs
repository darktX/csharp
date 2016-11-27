using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class Program
    {
        static public int GetRemainder(int a1,int b1)
        {
            int result, b2;
            int preva = 0;
            b2 = b1;
            while(a1>b2)
            {
                preva = b2;
                b2 = b2 + b1;

            }
            if(a1==b2)
            {
                result = 0;
                return result;
            }
            else
            {
                result = a1 - preva;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            if (n > 1)
            {
                while (n % i != 0)
                {
                    i++;
                }
                if (i == n)
                {
                    Console.WriteLine($"Liczba {n} jest liczbą pierwszą");
                }
                else
                {
                    Console.WriteLine($"Liczba {n} nie jest liczbą pierwszą");
                }
            }
            else
            {
                Console.WriteLine($"Liczba {n} nie jest liczbą pierwszą");
            }
            n = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetRemainder(n,i));
            Console.ReadKey();
        }
    }
}
