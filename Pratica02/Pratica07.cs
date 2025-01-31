using System;
using System.Globalization;
using System.Numerics;

namespace Pratica07
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pi, volume;
            pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (4 / 3.0) * pi * Math.Pow(r, 3);


            Console.WriteLine("VOLUME = "+volume.ToString("F3", CultureInfo.InvariantCulture));
            

        }
    }
}