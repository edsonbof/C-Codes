using System;
using System.Globalization;
namespace MediaTrimestral {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Informe o nome do Aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a segunda nota: ");
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a terceira nota: ");
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO!");
            } else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }
        }
    }
}
