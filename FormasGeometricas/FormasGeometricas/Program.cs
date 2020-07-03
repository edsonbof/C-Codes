using System;
using System.Globalization;

namespace FormasGeometricas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe 3 valores com pontos flutuantes exemplo: (2.1)");
            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo, circulo, trapezio, quadrado, retangulo;

            triangulo = valor1 * valor3 / 2.0;
            circulo = 3.14159 * valor3 * valor3;
            trapezio = (valor1 + valor2) / 2.0 * valor3;
            quadrado = valor2 * valor2;
            retangulo = valor1 * valor2;

            Console.WriteLine("O valor de triangulo é: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de circulo é: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de trapezio é: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de quadrado é: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de retangulo é: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
