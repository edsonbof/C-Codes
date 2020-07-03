using System;
using System.Globalization;

namespace PlanoCartesiano {
    class Program {
        static void Main(string[] args) {
            double x, y;

            Console.Write("Informe o valor X: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor Y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-----------------------------------------------");
            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            } else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            } else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            } else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y > 0.0){
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }

        }
    }
}
