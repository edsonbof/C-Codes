using System;

namespace NumerosImparesPorPeriodo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um valor e veja os numeros Impares dentro do periodo:");

            int x = int.Parse(Console.ReadLine());

            for (int i=1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.Write(i);
                }
            }
        }
    }
}
