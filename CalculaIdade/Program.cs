using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a idade");
            Pessoa pessoa = new Pessoa();

            Console.Write("Qual seu nome? ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            pessoa.AnoNasc = Convert.ToInt32(Console.ReadLine());

            pessoa.ExibirDados();
            Console.ReadKey();
        }
    }
}
