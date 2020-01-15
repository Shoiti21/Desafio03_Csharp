using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03_Csharp.Model
{
    class Caminhao:Veiculo
    {
        public Caminhao(String marca, String modelo, String placa, String cor, bool isligado, int litroscombustivel, int velocidade, double preco) : base(marca, modelo, placa, cor, isligado, litroscombustivel, velocidade, preco)
        {

        }
		public void abastecer(float qtd)
		{
			base.abastecer(Convert.ToInt32(qtd));
			if (this.LitrosCombustivel > 150)
			{
				this.LitrosCombustivel = 150;
			}
		}
		public void acelerar()
		{
			if (this.isLigado == true)
			{
				this.LitrosCombustivel--;
				this.Velocidade += 40;
			}
			else
			{
				Console.WriteLine("O caminhão está desligado");
			}
		}
	}
}
