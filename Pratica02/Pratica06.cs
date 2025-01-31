using System;
using System.Globalization;
using System.Numerics;

namespace Pratica06
{
    class Progam
    {
        static void Main(string[] args)
        {
            string nome;
            double fixo, totalvendas, salario;

            nome = Console.ReadLine();
            fixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = fixo + totalvendas * 15 / 100;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture) );



        }
    }
}