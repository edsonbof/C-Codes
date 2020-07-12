using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterRealDolar {
    class ConversorMoeda {

        public static double iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * iof / 100.0;
        }
    }
}
