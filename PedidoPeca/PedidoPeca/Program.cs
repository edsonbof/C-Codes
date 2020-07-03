using System;
using System.Globalization;

namespace PedidoPeca {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o codigo da peça: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de peças: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de cada peça: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("----------------------------------------");

            Console.Write("Informe o codigo da peça 2: ");
            int codigo2 = int.Parse(Console.ReadLine());

            Console.Write("Informe a segunda quantidade de peças: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de cada peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor do primeiro conjunto de peça é: "+ valor * quantidade);

            Console.WriteLine("O valor do segundo conjunto de peça é: " + valor2 * quantidade2);

        }
    }
}
