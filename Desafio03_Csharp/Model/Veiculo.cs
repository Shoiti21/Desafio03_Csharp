using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03_Csharp.Model
{
	class Veiculo
	{
		private String _Marca, _Modelo, _Placa, _Cor;
		private bool _isLigado;
		protected int _LitrosCombustivel, _Velocidade;
		private double _Preco;

		public Veiculo(String marca, String modelo, String placa, String cor, bool isligado, int litroscombustivel, int velocidade, double preco)
		{
			this.Marca = marca;
			this.Modelo = modelo;
			this.Placa = placa;
			this.Cor = cor;
			this.isLigado = isligado;
			this.LitrosCombustivel = litroscombustivel;
			this.Velocidade = velocidade;
			this.Preco = preco;
		}
		public String Marca{ get; }
		public String Modelo { get; }
		public String Placa { get; }
		public String Cor { get; }
		public bool isLigado { get; }
		public int LitrosCombustivel { get; set; }
		public int Velocidade { get; set; }
		public double Preco { get; }

		public void abastecer(int qtd)
		{
			if (qtd >= 0)
			{
				this.LitrosCombustivel += qtd;
			}
			else
			{
				Console.WriteLine("Você não pode abastecer essa quantidade.");
			}
			if (this.LitrosCombustivel < 0)
			{
				this.LitrosCombustivel = 0;
			}
		}
		public void acelerar()
		{
			if (this.isLigado == true)
			{
				this.LitrosCombustivel--;
				this.Velocidade += 20;
			}
			else
			{
				Console.WriteLine("O carro está desligado");
			}
		}
	}
}
