using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class Retang
    {
       public double largura, altura;

        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return largura*2+ altura*2;
        }

        public double diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
