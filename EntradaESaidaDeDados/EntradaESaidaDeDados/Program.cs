using System;
using System.Globalization;

namespace EntradaESaidaDeDados {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + "cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preco é $ " + preco2);
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + "e genero: " + genero);
            Console.WriteLine("Medida com oitos casas decimais: " + medida);
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal ivariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
