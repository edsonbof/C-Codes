using System;
using System.Globalization;

namespace ConverterRealDolar {
    class Program {
        static void Main(string[] args) {

            Console.Write("Informe a cotação do dolár atual: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe quantos doláres será comprado: ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorMoeda.DolarParaReal(quant, cot);

            Console.WriteLine("O valor a ser pago em reais é = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
