﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Sumatoria_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int n;
            double s = 0;

            Console.Write("Ingrese el valor de n: ");
            entrada = Console.ReadLine();
            n = int.Parse(entrada);

            for (int i = 1; i <= n; i++)
            {
                s += Math.Log10(Math.Pow(2,i)); 
            }

            Console.WriteLine("\nEl valor de la sumatoria es: {0}", s);
            Console.ReadLine();
        }
    }
}
