using System;
using System.Globalization;

namespace CadastroPessoa {
    class Program {
        static void Main(string[] args) {

            DadosPessoas dados1, dados2;
            dados1 = new DadosPessoas();
            dados2 = new DadosPessoas();

            Console.Write("Informe o nome da Primeira pessoa: ");
            dados1.nome = Console.ReadLine();
            Console.Write("Infrome o salario: ");
            dados1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("informe o nome da Segunda pessoa: ");
            dados2.nome = Console.ReadLine();
            Console.Write("Informe o salario: ");
            dados2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (dados1.salario + dados2.salario) / 2.0;

            Console.WriteLine("Salario médio = " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
