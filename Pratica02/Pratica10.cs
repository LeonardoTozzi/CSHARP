using System;
using System.Globalization;
using System.Text;

namespace Pratica10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quatd, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            
            nota = 50;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            
            nota = 20;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            
            nota = 10;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            
            nota = 2;
            quatd = resto / nota;
            Console.WriteLine(quatd + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
            Console.ReadLine();
        }
    }
}