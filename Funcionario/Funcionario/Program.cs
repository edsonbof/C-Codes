using System;
using System.Globalization;

namespace Funcionario {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o numero do funcionario: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Informe o salario desse funcionario: ");
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = salarioHora * horasTrabalhadas;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("O numero do funcionario é: " + numero);
            Console.WriteLine("O salario do funcionario é: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
