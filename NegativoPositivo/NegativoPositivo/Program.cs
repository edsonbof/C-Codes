using System;

namespace NegativoPositivo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 0) {
                Console.WriteLine("Positivo!");
            } else {
                Console.WriteLine("Negativo!");
            }
        }
    }
}
