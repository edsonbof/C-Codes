using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DadosFuncionario {
    class Funcionario {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido() {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem) {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
        }

        public override string ToString() {
            return nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        
        }
    }
}
