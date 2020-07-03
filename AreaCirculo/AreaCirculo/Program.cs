using System;
using System.Globalization;

namespace AreaCirculo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o raio do circulo: ");
            float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double area = pi * raio * raio;

            Console.WriteLine("O valor da area é: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
