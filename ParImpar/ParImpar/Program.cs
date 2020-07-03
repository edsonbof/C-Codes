using System;

namespace ParImpar {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0) {
                Console.WriteLine("Numero PAR!");
            }
            else {
                Console.WriteLine("Numero IMPAR!");
            }
        }
    }
}
