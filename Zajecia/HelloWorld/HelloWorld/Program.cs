using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int liczba1 = 15;
            Console.Write("liczba1 = ");
            Console.WriteLine(liczba1);

            //Tutaj zaczynamy drugi program - kalkulator
            Console.WriteLine("Witaj w kalkulatorze");
            Console.Write("Podaj pierwszą liczbę: ");
            int liczbaJeden = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int liczbaDwa = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Dodawanie: {liczbaJeden}+{liczbaDwa} = {liczbaJeden + liczbaDwa}");
            Console.WriteLine($"Odejmowanie: {liczbaJeden}-{liczbaDwa} = {liczbaJeden - liczbaDwa}");
            Console.WriteLine($"Mnożenie: {liczbaJeden}*{liczbaDwa} = {liczbaJeden * liczbaDwa}");
            Console.WriteLine($"Dzielenie: {liczbaJeden}/{liczbaDwa} = {(double)liczbaJeden / liczbaDwa}");
            //Pobieranie znaków
            Console.Write("Podaj znak ");
            char znak = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Nasz znak to: {znak}");

            //Operacje na tekscie

            Console.WriteLine("Podaj tekst: ");
            string napis = Console.ReadLine();

            Console.WriteLine($"Nasz tekst to: {napis}");
            Console.ReadLine();
        }
    }
}
