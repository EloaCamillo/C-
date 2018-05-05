using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Notas
{
    class Aluno
    {
       public string nome;
       public double nota1, nota2, nota3;

        public double notafinal()
        {
            return nota1 + nota2 + nota3;
        }

        public double quantofalta()
        {
            return 60.0 - notafinal();
        }
        public void aprovado()
        {
            if (notafinal() >= 60)
            {
                Console.Write("Aprovado");

            }
            else
            {
                Console.WriteLine(" Reprovado ");
                Console.WriteLine("Faltam : " + quantofalta().ToString("F2", CultureInfo.InstalledUICulture) + " Pontos ");

            }
        }

    }
}
