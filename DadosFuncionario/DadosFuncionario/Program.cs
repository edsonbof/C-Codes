using System;
using System.Globalization;

namespace DadosFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.Write("Informe seu nome: ");
            func.nome = Console.ReadLine();

            Console.Write("Informe seu salario bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe a % de imposto: ");
            func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + func);

            Console.Write("Digite a % para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
