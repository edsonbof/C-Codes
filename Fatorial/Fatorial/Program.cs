using System;

namespace Fatorial {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira um valor e descubra seu fatorial: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine("O fatorial é = "+ fat);
        }
    }
}
