using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario1 F;
            double porc;
            F = new Funcionario1();
            Console.Write("Nome :");
            F.nome = Console.ReadLine();
            Console.Write("Salario Bruto : ");
            F.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto :");
            F.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do funcionario: " + F);
            Console.Write("Deseja aumentar o salario em qual porcentagem?");
            porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.aumentarSalario(porc);
            Console.WriteLine("Dados do funcionario: " + F);
            Console.ReadLine();


        }
    }
}
