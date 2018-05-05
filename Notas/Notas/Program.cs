using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x;
           
            x = new Aluno();

            Console.WriteLine("Digite seu nome");
            x.nome = Console.ReadLine();
            Console.WriteLine("Digite as notas 1, 2 e 3");
            x.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final :"+ x.notafinal());
            x.aprovado();
            Console.ReadLine();

        }
    }
}
