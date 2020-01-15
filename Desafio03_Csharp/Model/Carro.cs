using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03_Csharp.Model
{
    class Carro : Veiculo
    {
        public Carro(String marca, String modelo, String placa, String cor, bool isligado, int litroscombustivel, int velocidade, double preco) : base(marca, modelo, placa, cor, isligado, litroscombustivel, velocidade, preco) 
        {
        }
		public void abastecer(int qtd)
		{
			base.abastecer(qtd);
			if (this.LitrosCombustivel > 100)
			{
				this.LitrosCombustivel = 100;
			}
		}
		public void acelerar()
		{
			base.acelerar();
		}
	}
}
