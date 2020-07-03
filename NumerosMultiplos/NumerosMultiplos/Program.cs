using System;

namespace NumerosMultiplos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o Primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insira o Segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            if(a % b == 0 || b % a == 0) {
                Console.WriteLine("Os valores informados são multiplos!");
            } else {
                Console.WriteLine("Os valores informados não são multiplos!");
            }

        }
    }
}
