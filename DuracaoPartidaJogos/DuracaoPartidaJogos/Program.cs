using System;

namespace DuracaoPartidaJogos {
    class Program {
        static void Main(string[] args) {

            double horaInicial, horaFinal, duracao;

            Console.Write("Informe o horario inicial do jogo: ");
            horaInicial = double.Parse(Console.ReadLine());
            Console.Write("Informe o horario final do jogo: ");
            horaFinal = double.Parse(Console.ReadLine());

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            } else {
                duracao = 24 - horaInicial + horaInicial;
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
