using System;
using System.Globalization;

namespace Lanchonete {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("BEM VINDO(A) A LANCHONETE DO ED");
            Console.WriteLine(" CODIGO 1 CACHORRO QUENTE R$4.00 \n CODIGO 2 X-SALADA R$4.50 \n CODIGO 3 X-BACON R$5.00 \n CODIGO 4 TORRADA SIMPLES R$2.00 \n CODIGO 5 REFRIGERANTE R$1.50 ");
            Console.WriteLine("------------------------------");
            Console.Write("Informe o codigo do pedido: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade do pedido: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valor;
            if (codigo == 1) {
                valor = 4.00 * quantidade;
            }
            else if (codigo == 2) {
                valor = 4.50 * quantidade;
            }
            else if (codigo == 3) {
                valor = 5.00 * quantidade;
            }
            else if (codigo == 3) {
                valor = 5.00 * quantidade;
            }
            else if (codigo == 4) {
                valor = 2.00 * quantidade;
            }
            else {
                valor = 1.50 * quantidade;
            }
     
             Console.WriteLine("O valor do pedido ficou R$" + valor.ToString("F2"));
        }  
        
    }
}
