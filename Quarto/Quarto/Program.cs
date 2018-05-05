using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] quarto;

            quarto = new Aluguel[10];

            Console.WriteLine("Numero de estudantes qua vão alugar o quarto");
            int num = int.Parse(Console.ReadLine());

            for(int i =0; i<num; i++)
            {
                Console.WriteLine("Dados do " + i + "alugeul");
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Numero do quarto:");
                int q = int.Parse(Console.ReadLine());
                quarto[q] = new Aluguel(nome, email);
                
            }
            Console.WriteLine("Quartos ocupados");

            for(int i=0; i < 10; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine(i + ":" + quarto[i]);
                }

            }
            Console.ReadLine();

        }
    }
}
