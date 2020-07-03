using System;
using System.Globalization;

namespace EntradaViaConsole {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ente com um preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha):");
            String[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2]);

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            


        }
    }
}
