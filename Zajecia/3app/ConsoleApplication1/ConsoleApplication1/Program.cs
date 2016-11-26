using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
           
            Krzeslo moje = new ConsoleApplication1.Krzeslo();
            Console.WriteLine($"{moje.mojaMetoda()}");
            int suma = 0;
            for(int a=0; i<=10;i++)
            {
                suma += i;


            }
            moje.iloscNog

            Console.ReadLine();
        }
    }
}
