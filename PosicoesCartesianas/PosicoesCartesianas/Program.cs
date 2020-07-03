using System;
using System.Linq;

namespace PosicoesCartesianas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe os valores X e Y para saber sua posição no quadrante");

            string[] valores = Console.ReadLine().Split(' ');
         
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                } else if (x < 0 && y < 0){
                    Console.WriteLine("Terceiro");
                } else {
                    Console.WriteLine("Quarto");
                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }
        }
    }
}
