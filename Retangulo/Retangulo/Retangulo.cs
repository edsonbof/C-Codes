using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo {
    class Retangulo {

        public double altura;
        public double largura;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro() {
            return 2 * (largura + altura);
        }

        public double Diagonal() {
            return Math.Sqrt(largura * largura + altura * altura);

        }
    }
}
