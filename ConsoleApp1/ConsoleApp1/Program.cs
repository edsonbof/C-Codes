﻿using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira um valor: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000.0) {
                imposto = 0.0;
            } 
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08; 
            } 
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.00 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("RS" + imposto.ToString("F3", CultureInfo.InvariantCulture));
            }
        }
    }
}
