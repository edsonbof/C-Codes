using System;

namespace Soma {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o primeiro valor para obter a soma: ");
            int primeiro = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor para obter a soma: ");
            int segundo = int.Parse(Console.ReadLine());

            int soma = primeiro + segundo;

            Console.WriteLine("A soma de ambos valores são: " + soma);

        }
    }
}
