﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario1
{
    class Funcionario1
    {
        public string nome;
        public double salarioBruto;
        public double desconto;


        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem)
        {
            salarioBruto += (salarioBruto * porcentagem) / 100;
        }

        public override string ToString()
        {
            return nome + ", R$ " + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
