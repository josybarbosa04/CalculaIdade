using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade
{
    public class Pessoa
    {
		private int anoNasc;

		public int AnoNasc
		{
			get { return this.anoNasc; }
			set { anoNasc = value; }
		}

		private String nome;

		public String Nome
		{
			get { return this.nome; }
			set { nome = value.ToUpper(); }
		}

		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + Nome);
			Console.WriteLine("Ano de nascimento: " + AnoNasc);
			int idade = CalcularIdade();
			Console.WriteLine("Idade: " + idade + " anos.");
		}

		private int CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			int idade = ano - this.anoNasc;

			return idade;
		}

	}
}
