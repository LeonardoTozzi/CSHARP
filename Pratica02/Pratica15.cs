﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;
            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
