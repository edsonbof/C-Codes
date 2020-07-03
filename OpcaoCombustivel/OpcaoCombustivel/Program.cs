using System;

namespace OpcaoCombustivel {
    class Program {
        static void Main(string[] args) {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("-------Combustiveis-------");
            Console.Write(" Digite:\n 1 para Álcool\n 2 para Gasolina\n 3 para Diesel\n 4 para FIM\n Opção:");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    Console.WriteLine("Opção desejada ALCOOL");
                    alcool = alcool + 1;
                } else if (tipo == 2) {
                    Console.WriteLine("Opção desejada Gasolina");
                    gasolina = gasolina + 1;
                } else if (tipo == 3){
                    Console.WriteLine("Opção desejada Diesel");
                    diesel = diesel + 1;
                }
                Console.Write("Informe novamente o tipo de combustivel preferido:");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
