using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03_Csharp.Model
{
    class Aviao:Veiculo
    {
        public Aviao(String marca, String modelo, String placa, String cor, bool isligado, int litroscombustivel, int velocidade, double preco) : base(marca, modelo, placa, cor, isligado, litroscombustivel, velocidade, preco)
        {

        }
		public void abastecer(String qtd)
		{
			base.abastecer(Convert.ToInt32(qtd));
			if (this.LitrosCombustivel > 600)
			{
				this.LitrosCombustivel = 600;
			}
		}
		public void acelerar()
		{
			if (this.isLigado == true)
			{
				this.LitrosCombustivel--;
				this.Velocidade += 70;
			}
			else
			{
				Console.WriteLine("O avião está desligado");
			}
		}
	}
}
