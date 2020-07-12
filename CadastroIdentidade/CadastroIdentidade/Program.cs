using System;

namespace CadastroIdentidade {
    class Program {
        static void Main(string[] args) {          

            Identidade Dados1 = new Identidade();
            Identidade Dados2 = new Identidade();

            Console.Write("Informe o nome da primeira pessoa: ");
            Dados1.nome = Console.ReadLine();
            Console.Write("Informe a idade da pessoa: ");
            Dados1.idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome da segunda pessoa: ");
            Dados2.nome = Console.ReadLine();
            Console.Write("Informe a idade da pessoa: ");
            Dados2.idade = int.Parse(Console.ReadLine());

            if (Dados1.idade > Dados2.idade) {
                Console.WriteLine("Pessoa mais velha: " + Dados1.nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + Dados2.nome);
            }
        }
    }
}
