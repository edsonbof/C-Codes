using System;
using System.Globalization;
namespace Retangulo {
    class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();
            
            Console.Write("Informe a Largura do Retangulo: ");
             ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe a Altura do Retangulo: ");
             ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
