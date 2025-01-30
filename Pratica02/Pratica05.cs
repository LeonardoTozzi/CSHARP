using System;
using System.Globalization;
using System.Numerics;

namespace Pratica05
{
    class Progam
    {
        static void Main(string[] args)
        {
            int x, y;
            double z;
            x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = x * y / 12.0;
            Console.WriteLine(z.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}