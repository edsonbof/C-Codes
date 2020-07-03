using System;

namespace ValidacaoDeSenha {
    class Program {
        static void Main(string[] args) {
            Console.Write("Cadastre sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002) {
                Console.WriteLine("Senha invalida!");
                senha = int.Parse(Console.ReadLine());
            } 
                Console.WriteLine("Acesso Permitido!");
      
        }
    }
}
